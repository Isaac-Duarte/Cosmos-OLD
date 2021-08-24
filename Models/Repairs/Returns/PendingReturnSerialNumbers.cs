using System.Xml.Serialization;

namespace Cosmos.Models.Returns
{
    [XmlRoot(ElementName = "serialNumber")]
    public class PendingReturnSerialNumbers
    {
        [XmlElement(ElementName = "dangerousGoods")]
        public string SerialNumber { get; set; }
    }
}