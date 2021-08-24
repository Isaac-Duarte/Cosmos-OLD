using System;
using System.Collections;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using Cosmos.Models;
using Cosmos.Models.Core;

namespace Cosmos.Services
{
    public partial class GSXService 
	{
		private WebServiceHandler webServiceHandler;
		private string serviceUrl;
		private string sslCertFilename;
		private string sslCertPassword;
		private string userSessionId { get; set; }

		public GSXService(string serviceUrl, string sslCertFilename, string sslCertPassword)
		{
			this.serviceUrl = serviceUrl;
			this.sslCertFilename = sslCertFilename;
			this.sslCertPassword = sslCertPassword;

			webServiceHandler =new WebServiceHandler(
				serviceUrl,
				sslCertFilename,
				sslCertPassword,
				"log", // TEMP
				"Cosmos 1.0");
		}

		/// <summary>
		/// Get an element from the container.
		/// </summary>
		/// <param name="container">XML container to cycle.</param>
		/// <param name="name">Name of element to fetch.</param>
		/// <returns>Element.</returns>
		public XElement GetElement(XContainer container, string name) 
		{
			return container.Descendants().FirstOrDefault(d => d.Name == name) ??
				container.Descendants().FirstOrDefault(d => d.Name.ToString().EndsWith(name));
		}

		/// <summary>
		/// Get a value from the container.
		/// </summary>
		/// <param name="container">XML container to cycle.</param>
		/// <param name="name">Name of element to fetch value from.</param>
		/// <returns>Value.</returns>
		public string GetValue(XContainer container, string name) 
		{
			return container.Descendants()
				.Where(d => string.Equals(d.Name.ToString(), name, StringComparison.InvariantCultureIgnoreCase))
				.Select(d => d.Value)
				.FirstOrDefault();
		}

		/// <summary>
		/// Parse given object and turn it into XML.
		/// </summary>
		/// <param name="wrapper">Object to parse.</param>
		/// <param name="envelope">Type of XML to send.</param>
		/// <returns>XML string.</returns>
		public string ParseWrapper(object wrapper, Envelope envelope) 
		{
			var xml = new StringBuilder();
			var type = string.Empty;
			var typeURL = string.Empty;

			switch (envelope) {
				case Envelope.AM:
					type = "am";
					typeURL = "core/asp/am";
					break;

				case Envelope.APAC:
					type = "apac";
					typeURL = "core/asp/apac";
					break;

				case Envelope.ASP:
					type = "asp";
					typeURL = "core/asp";
					break;

				case Envelope.Core:
					type = "core";
					typeURL = "core";
					break;

				case Envelope.EMEA:
					type = "emea";
					typeURL = "core/asp/emea";
					break;

				case Envelope.Global:
					type = "glob";
					typeURL = "global";
					break;

				case Envelope.IPHONE:
					type = "iph";
					typeURL = "iphone";
					break;

				case Envelope.LA:
					type = "la";
					typeURL = "core/asp/la";
					break;
			}

			xml
				.Append("<soapenv:Envelope xmlns:soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:" + type + "=\"http://gsxws.apple.com/elements/" + typeURL + "\">")
				.Append("<soapenv:Header/>")
				.Append("<soapenv:Body>");

			buildXML(wrapper, ref xml);

			xml
				.Append("</soapenv:Body>")
				.Append("</soapenv:Envelope>");

			return xml.ToString();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="wrapper"></param>
		/// <param name="envelope"></param>
		/// <param name="serviceUrl"></param>
		/// <param name="functionName"></param>
		/// <returns></returns>
		public async System.Threading.Tasks.Task<T> ExecuteAsync<T>(object wrapper, Envelope envelope, string functionName) 
		{
			var requestXML = ParseWrapper(wrapper, envelope);

			var responseXML = await webServiceHandler.CallAsync(
				requestXML,
				"POST",
				functionName);
			
			// **Implement Fault detection**
			XElement fault = GetElement(responseXML, "Fault");

			var type = typeof (T);
			var name = type.Name;

			/// I should probably do better attribute detection.
			if (type.CustomAttributes.Count() > 0)
			{
				var attribute = type.CustomAttributes.FirstOrDefault(a => a.AttributeType == typeof(XmlElement) | a.AttributeType == typeof(XmlRootAttribute));
				
				if (attribute != null)
					name = (string) attribute.ConstructorArguments[0].Value;
			}
			
			var element = GetElement(responseXML, name);


			if (element == null)
				return default(T);

			var serializer = new XmlSerializer(typeof(T));
			var reader = new StringReader(element.ToString());
			return (T) serializer.Deserialize(reader);
		}

		/// <summary>
		/// Build XML from the given object.
		/// </summary>
		private static void buildXML(object wrapper, ref StringBuilder xml) 
		{
			if (wrapper == null)
				return;

			var type = wrapper.GetType();
			var name = type.Name;

			/// I should probably do better attribute detection.
			if (type.CustomAttributes.Count() > 0)
			{
				var attribute = type.CustomAttributes.FirstOrDefault(a => a.AttributeType == typeof(XmlElement) | a.AttributeType == typeof(XmlRootAttribute));
				
				if (attribute != null)
				{
					var constructorArguments = attribute.ConstructorArguments.FirstOrDefault(
						a => ((string)a.Value).ToLower() ==  name.ToLower());
					
					if (constructorArguments != null)
						name = (string) constructorArguments.Value;
				}
				
				name = (string) type.CustomAttributes.ToArray()[0].ConstructorArguments[0].Value;
			}

			NameValueCollection attributes = null;
			var colonCutOffset = 0;

			try {
				var temp = wrapper as Wrapper;

				if (temp != null) {
					if (temp.Attributes != null)
						attributes = temp.Attributes;

					if (temp.ClassName != null)
						name = temp.ClassName;

					colonCutOffset = temp.ColonCutOffset;
				}
			}
			catch {}

			if (colonCutOffset > 0 &&
				name.Length > colonCutOffset)
				name =
					name.Substring(0, colonCutOffset) + ":" +
					name.Substring(colonCutOffset);

			// Add root tag with possible attributes.
			xml.Append("<" + name);

			if (attributes != null)
				foreach (var key in attributes.AllKeys)
					xml.Append(" " + key + "\"" + attributes[key] + "\"");

			xml.Append(">");

			// Cycle properties for values and children.
			foreach (var property in type.GetProperties(BindingFlags.Public | BindingFlags.Instance)) 
			{
				var obj = property.GetValue(wrapper, null);
				var propertyName = property.Name;

				if (propertyName == "Attributes" ||
					propertyName == "ColonCutOffset" ||
					propertyName == "ClassName")
					continue;

				if (obj is string) {
					xml
						.Append("<" + propertyName + ">")
						.Append(obj)
						.Append("</" + propertyName + ">");
				}
				else if (obj is Array) {
					var array = obj as Array;

					foreach (var item in array)
						buildXML(item, ref xml);
				}
				else {
					buildXML(obj, ref xml);
				}
			}

			// End tag.
			xml.Append("</" + name + ">");
		}
	}
}