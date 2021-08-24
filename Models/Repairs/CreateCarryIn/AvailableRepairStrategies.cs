using System.Xml.Serialization;

namespace Cosmos.Models.Repairs
{
    [XmlRoot("availableRepairStrategies")]
    public class AvailableRepairStrategies 
    {

        [XmlElement(ElementName = "availableRepairStrategy")]
        public string AvailableRepairStrategy { get; set; }
    }
}