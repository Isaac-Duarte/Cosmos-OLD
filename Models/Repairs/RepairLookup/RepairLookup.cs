using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Cosmos.Models.Repairs
{
    [XmlRoot("repairLookup")]
    public class RepairLookup
    {
        /// <summary>
        /// Repair confirmation number
        /// </summary>
        [XmlElement(ElementName = "repairConfirmationNumber")]
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string RepairConfirmationNumber { get; set; }

        /// <summary>
        /// Repair number
        /// </summary>
        [XmlElement(ElementName = "repairNumber")]
        [StringLength(12, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string RepairNumber { get; set; }

        /// <summary>
        /// Repair type. Click to see the list of Valid Repair Types
        /// </summary>
        [XmlElement(ElementName = "repairType")]
        [StringLength(30, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string RepairType { get; set; }

        /// <summary>
        /// Repair status. Click to see the list of Valid Repair Status
        /// </summary>
        [XmlElement(ElementName = "repairStatus")]
        [StringLength(40, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string RepairStatus { get; set; }

        /// <summary>
        /// Purchase Order Number
        /// </summary>
        [XmlElement(ElementName = "purchaseOrderNumber")]
        [StringLength(35, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string PurchaseOrderNumber { get; set; }

        /// <summary>
        /// Customer name
        /// </summary>
        [XmlElement(ElementName = "customerName")]
        [StringLength(50, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string CustomerName { get; set; }

        /// <summary>
        /// Created on date. See all values for Supported Date Formats
        /// </summary>
        [XmlElement(ElementName = "createdOn")]
        public string CreatedOn { get; set; }

        /// <summary>
        /// "Indicates whether AppleCare+ is consumed or not. Values can be Y or N. Y indicates "AppleCare+ is consumed" N indicates "AppleCare+ is not consumed"
        /// </summary>
        [XmlElement(ElementName = "isACPlusConsumed")]
        [StringLength(1, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string IsACPlusConsumed { get; set; }

        /// <summary>
        /// "Indicates whether unit is covered by AppleCare+. Possible values are Y
        /// </summary>
        [XmlElement(ElementName = "acPlusFlag")]
        public string AcPlusFlag { get; set; }

        /// <summary>
        /// "Indicates which service type was used for the Repair. Possible values are RFD or RPL.  RFD indicates Refund is consumed RPL indicates Replace is consumed"
        /// </summary>
        [XmlElement(ElementName = "consumerLawApplied")]
        [StringLength(10, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string ConsumerLawApplied { get; set; }

        /// <summary>
        /// This indicates the symptom that the technician observes on the unit
        /// </summary>
        [XmlElement(ElementName = "reportedSymptomCode")]
        [StringLength(7, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string ReportedSymptomCode { get; set; }

        /// <summary>
        /// This indicates the issue that the technician observes on the unit
        /// </summary>
        [XmlElement(ElementName = "reportedIssueCode")]
        [StringLength(7, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string ReportedIssueCode { get; set; }
    }
}