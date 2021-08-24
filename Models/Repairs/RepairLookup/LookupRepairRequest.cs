using System.Xml.Serialization;
using Cosmos.Models.Core;

namespace Cosmos.Models.Repairs
{
    [XmlRoot("RepairLookupRequest")]
    public class LookupRepairRequest : Wrapper
    {
        /// <summary>
        /// User session Id
        /// </summary>
        [XmlElement(ElementName = "userSession")]
        public UserSession UserSession { get; set; }

        /// <summary>
        /// Request data
        /// </summary>
        [XmlElement(ElementName = "lookupRequestData")]
        public LookupRequestData LookupRequestData { get; set; }
    }
}