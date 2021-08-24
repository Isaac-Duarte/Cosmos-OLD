using System.Xml.Serialization;
using Cosmos.Models.Core;

namespace Cosmos.Models.Returns
{
    [XmlRoot("PartsPendingReturnResponse")]
    public class PendingReturnResponse
    {
        /// <summary>
        /// Indicates a unique string returned by the server for this operation. It can be used for reporting purpose in case the operation fails.
        /// </summary>
        [XmlElement(ElementName = "operationId")]
        public string OperationId { get; set; }

        /// <summary>
        /// Includes input information required to retrieve the list of parts that are pending return.
        /// </summary>
        [XmlElement(ElementName = "partsPendingResponse")]
        public PendingReturnsResponseData[] PendingReturnsResponseData { get; set; }

        /// <summary>
        /// The soft error message displayed if there is a high priority communication for the user. This is an optional field that is 
        /// present only if there are priority communications for the user.
        /// </summary>
        [XmlElement(ElementName = "communicationMessage")]
        public string CommunicationMessage { get; set; }

    }
}