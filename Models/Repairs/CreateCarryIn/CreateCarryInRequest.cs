using System.Xml.Serialization;
using Cosmos.Models.Core;

namespace Cosmos.Models.Repairs
{
    public class CreateCarryInRequest : Wrapper 
    {
        [XmlElement(ElementName = "userSession")]
        public UserSession UserSession { get; set; }

        [XmlElement(ElementName = "repairData")]
        public CarryInRepairData RepairData { get; set; }
    }
}