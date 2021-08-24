using System.Xml.Serialization;

namespace Cosmos.Models.Repairs
{
    [XmlRoot("replacementDetails")]
    public class ReplacementDetails
    {
        /// <summary>
        /// Replacement Serial Number Details
        /// </summary>
        [XmlElement(ElementName = "serialDetails")]
        public SerialDetails[] SerialDetails { get; set; }  
    }
}