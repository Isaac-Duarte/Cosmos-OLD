using System.Xml.Serialization;

namespace Cosmos.Models.Repairs
{
    [XmlRoot("componentCheckDetails")]
    public class ComponentCheckDetails 
    {
        [XmlElement(ElementName = "component")]
        public string Component { get; set; }

        [XmlElement(ElementName = "serialNumber")]
        public string SerialNumber { get; set; }
    }
}