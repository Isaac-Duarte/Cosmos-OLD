using System.Xml.Serialization;

namespace Cosmos.Models.Repairs
{
    [XmlRoot("parts")]
    public class Parts 
    {
        [XmlElement(ElementName = "availability")]
        public string availability { get; set; }

        [XmlElement(ElementName = "currency")]
        public string currency { get; set; }

        [XmlElement(ElementName = "netPrice")]
        public string netPrice { get; set; }

        [XmlElement(ElementName = "partNumber")]
        public string partNumber { get; set; }

        [XmlElement(ElementName = "partType")]
        public string partType { get; set; }

        [XmlElement(ElementName = "quantity")]
        public string quantity { get; set; }
    }
}