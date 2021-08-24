using System.Xml.Serialization;

namespace Cosmos.Models.Core
{
    [XmlRoot("userSession")]
    public class UserSession : Wrapper 
    {
        [XmlElement(ElementName = "userSessionId")]
        public string UserSessionId { get; set; }
    }
}