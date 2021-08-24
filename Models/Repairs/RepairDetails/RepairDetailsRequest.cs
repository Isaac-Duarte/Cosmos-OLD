using System.Xml.Serialization;
using Cosmos.Models.Core;

namespace Cosmos.Models.Repairs
{
    [XmlRoot("RepairDetailsRequest")]
    public class RepairDetailsRequest : Wrapper
    {
        /// <summary>
        /// User session Id
        /// </summary>
        [XmlElement(ElementName = "userSession")]
        public UserSession UserSession { get; set; }

        /// <summary>
        /// Identifier for the repair for which detail is needed.
        /// </summary>
        [XmlElement(ElementName = "dispatchId")]
        public string DispatchId { get; set; }
    }
}