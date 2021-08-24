using System.Xml.Serialization;
using Cosmos.Models.Core;

namespace Cosmos.Models.Returns
{
    [XmlRoot("PartsPendingReturnRequest")]
    public class PendingReturnRequest : Wrapper
    {
        /// <summary>
        /// User session Id
        /// </summary>
        [XmlElement(ElementName = "userSession")]
        public UserSession UserSession { get; set; }

        /// <summary>
        /// Includes input information required to retrieve the list of parts that are pending return.
        /// </summary>
        [XmlElement(ElementName = "repairData")]
        public PendingReturnRepairData PendingReturnRepairData { get; set; }

    }
}