using System.Xml.Serialization;
using Cosmos.Models.Core;
using static Cosmos.Services.GSXService;

namespace Cosmos.Models.Authentication
{
    public class AuthenticateRequest : Wrapper 
    {
        [XmlElement(ElementName = "userId")]
        public string UserId { get; set; }

        [XmlElement(ElementName = "languageCode")]
        public string LanguageCode { get; set; }

        [XmlElement(ElementName = "userTimeZone")]
        public string UserTimeZone { get; set; }

        [XmlElement(ElementName = "serviceAccountNo")]
        public string ServiceAccountNo { get; set; }
    }
}