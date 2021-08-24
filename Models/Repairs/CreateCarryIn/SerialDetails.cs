using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Cosmos.Models.Repairs
{
    public class SerialDetails
    {
        /// <summary>
        /// Serial number
        /// </summary>
        [XmlElement(ElementName = "serialNumber")]
        [StringLength(18, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Alternate Device Id number
        /// </summary>
        [XmlElement(ElementName = "alternateDeviceId")]
        [StringLength(18, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string AlternateDeviceId { get; set; }

        /// <summary>
        /// Alternate Device Id2 number
        /// </summary>
        [XmlElement(ElementName = "data1")]
        [StringLength(18, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string Data1 { get; set; }

        /// <summary>
        /// Serial Status
        //  Possible values are : Active/Replaced/Original
        /// </summary>
        [XmlElement(ElementName = "serialStatus")]
        [StringLength(100, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string SerialStatus { get; set; }

        /// <summary>
        /// Serial Status Date
        /// </summary>
        [XmlElement(ElementName = "serialStatusDate")]
        [StringLength(12, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string SerialStatusDate { get; set; }
    }
}