using System.Xml.Serialization;
using Cosmos.Models.Core;

namespace Cosmos.Models.Repairs
{
    [XmlRoot("RepairDetailsResponse")]
    public class RepairDetailsResponse
    {
        /// <summary>
        /// Indicates a unique string returned by the server for this operation. It can be used for reporting purpose in case the operation fails.
        /// </summary>
        [XmlElement(ElementName = "operationId")]
        public string OperationId { get; set; }

        [XmlElement(ElementName = "lookupResponseData")]
        public RepairDetailsResponseData RepairDetailsResponseData { get; set; }
    }
}