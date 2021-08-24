using System.Xml.Serialization;
using Cosmos.Models.Core;

namespace Cosmos.Models.Repairs
{
    [XmlRoot("lookupResponseData")]
    public class LookupResponseData
    {
        /// <summary>
        /// Repair Lookup
        /// </summary>
        [XmlElement(ElementName = "repairLookup")]
        public RepairLookup[] RepairLookup { get; set; }

        /// <summary>
        /// Serial Number Replacement Details
        /// </summary>
        [XmlElement(ElementName = "replacementDetails")]
        public ReplacementDetails ReplacementDetails { get; set; }
    }
}