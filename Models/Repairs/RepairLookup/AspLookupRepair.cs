using System.Xml.Serialization;
using Cosmos.Models.Core;

namespace Cosmos.Models.Repairs
{
    [XmlRoot("aspLookupRepair")]
    public class AspLookupRepair : Wrapper 
    {
        [XmlElement(ElementName = "lookupRequestData")]
        public LookupRepairRequest LookupRepairRequest { get; set; }
    }
}