using System.Xml.Serialization;
using Cosmos.Models.Core;

namespace Cosmos.Models.Repairs
{
    [XmlRoot("RepairLookupResponse")]
    public class LookupRepairReponse
    {
        /// <summary>
        /// Indicates a unique string returned by the server for this operation. It can be used for reporting purpose in case the operation fails.
        /// </summary>
        [XmlElement(ElementName = "operationId")]
        public string OperationId { get; set; }
        
        /// <summary>
        /// An array containing repair data fetched for the given search parameters.
        /// </summary>
        [XmlElement(ElementName = "lookupResponseData")]
        public LookupResponseData LookupResponseData { get; set; }

         /// <summary>
        /// A soft error message conveying if there is a high priority communication pending for the user.
        /// </summary>
        [XmlElement(ElementName = "communicationMessage")]
        public string CommunicationMessage { get; set; }
    }
}