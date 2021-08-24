using System.Xml.Serialization;
using Cosmos.Models.Core;

namespace Cosmos.Models.Repairs
{
    [XmlRoot("aspLookupRepair")]
    public class AspRepairDetailsLookup : Wrapper 
    {
        [XmlElement(ElementName = "lookupRequestData")]
        public RepairDetailsRequest RepairDetailsRequest { get; set; }
    }
}