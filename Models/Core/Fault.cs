using System.Xml.Serialization;

namespace Cosmos.Models.Core
{
    public class Fault 
    {
        [XmlElement(ElementName = "faultcode")]
        public string FaultCode { get; set; }

        [XmlElement(ElementName = "faultstring")]
        public string Faultstring { get; set; }

        [XmlElement(ElementName = "detail")]
        public Detail Detail { get; set; }
    }
}