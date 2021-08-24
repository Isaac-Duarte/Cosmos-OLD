using System.Xml.Serialization;

namespace Cosmos.Models.Authentication
{
    public class AuthenticateResponse 
    {
        [XmlElement(ElementName = "operationId")]
        public string OperationId { get; set; }
        
        [XmlElement(ElementName = "userSessionId")]
        public string userSessionId { get; set; }
    }
}