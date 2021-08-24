using System.Xml.Serialization;

namespace Cosmos.Models.Core
{
    [XmlRoot("detail")]
    public class Detail 
    {
        [XmlElement(ElementName = "operationId")]
        public string OperationId { get;set; }
    }
}