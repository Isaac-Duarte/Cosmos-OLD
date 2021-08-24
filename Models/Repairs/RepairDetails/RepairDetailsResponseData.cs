using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using Cosmos.Models.Customer;

namespace Cosmos.Models.Repairs
{
    [XmlRoot(ElementName = "lookupResponseData")]
    public class RepairDetailsResponseData
    {
        /// <summary>
        /// The confirmation number of the repair to update.
        /// </summary>
        [XmlElement(ElementName = "repairConfirmationNumber")]
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string RepairConfirmationNumber { get; set; }

        /// <summary>
        /// Sold to code
        /// </summary>
        [XmlElement(ElementName = "soldToCode")]
        [StringLength(10, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string SoldToCode { get; set; }

        /// <summary>
        /// Warranty description
        /// </summary>
        [XmlElement(ElementName = "warrantyDescription")]
        [StringLength(35, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string WarrantyDescription { get; set; }

        /// <summary>
        /// Dispatch id
        /// </summary>
        [XmlElement(ElementName = "dispatchId")]
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string DispatchId { get; set; }

        /// <summary>
        /// SRO number
        /// </summary>
        [XmlElement(ElementName = "sroNumber")]
        [StringLength(12, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string SroNumber { get; set; }

        /// <summary>
        /// Serial #
        /// </summary>
        [XmlElement(ElementName = "serialNumber")]
        [StringLength(18, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string SerialNumber { get; set; }

        /// <summary>
        /// New serial #
        /// </summary>
        [XmlElement(ElementName = "newSerialNumber")]
        [StringLength(18, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string NewSerialNumber { get; set; }

        /// <summary>
        /// Dispatch sent date. See all values for Supported Date Formats
        /// </summary>
        [XmlElement(ElementName = "dispatchSentDate")]
        public string DispatchSentDate { get; set; }

        /// <summary>
        /// Sold to #
        /// </summary>
        [XmlElement(ElementName = "serviceAccountId")]
        [StringLength(10, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string ServiceAccountId { get; set; }

        /// <summary>
        /// Assigned to ship to code.
        /// </summary>
        [XmlElement(ElementName = "assignedToShipTo")]
        [StringLength(10, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string AssignedToShipTo { get; set; }

        /// <summary>
        /// Coverage status description
        /// </summary>
        [XmlElement(ElementName = "coverageStatusDescription")]
        [StringLength(35, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string CoverageStatusDescription { get; set; }

        /// <summary>
        /// Product name
        /// </summary>
        [XmlElement(ElementName = "productName")]
        [StringLength(40, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string ProductName { get; set; }

        /// <summary>
        /// Configuration
        /// </summary>
        [XmlElement(ElementName = "configuration")]
        [StringLength(100, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string Configuration { get; set; }

        /// <summary>
        /// SLA group description
        /// </summary>
        [XmlElement(ElementName = "slaGroupDescription")]
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string SlaGroupDescription { get; set; }

        /// <summary>
        /// PO #
        /// </summary>
        [XmlElement(ElementName = "purchaseOrderNumber")]
        [StringLength(35, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string PurchaseOrderNumber { get; set; }

        /// <summary>
        /// Reference #
        /// </summary>
        [XmlElement(ElementName = "referenceNumber")]
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// Notes
        /// </summary>
        [XmlElement(ElementName = "notes")]
        [StringLength(4000, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string Notes { get; set; }

        /// <summary>
        /// Zone
        /// </summary>
        [XmlElement(ElementName = "zone")]
        [StringLength(4, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string Zone { get; set; }

        /// <summary>
        /// Primary address
        /// </summary>
        [XmlElement(ElementName = "primaryAddress")]
        public CustomerAddress PrimaryAddress { get; set; }

        /// <summary>
        /// Secondary address
        /// </summary>
        [XmlElement(ElementName = "secondaryAddress")]
        public CustomerAddress SecondaryAddress { get; set; }

        /// <summary>
        /// Assigned to location address.
        /// </summary>
        [XmlElement(ElementName = "assignedToLocationAddress")]
        public CustomerAddress AssignedToLocationAddress { get; set; }

        /// <summary>
        /// Parts information
        /// </summary>
        [XmlElement(ElementName = "partsInfo")]
        [StringLength(25, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public RepairOrderDetails[] PartsInfo { get; set; }

        /// <summary>
        /// Value of CS code
        /// </summary>
        [XmlElement(ElementName = "csCode")]
        [StringLength(20, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string CsCode { get; set; }

        /// <summary>
        /// Indicates whether the parts are to be replenished or not. Possible values are Y or N
        /// </summary>
        [XmlElement(ElementName = "isNonReplenished")]
        [StringLength(1, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string IsNonReplenished { get; set; }

        /// <summary>
        /// Indicates whether AppleCare+ is consumed or not. Values can be Y or N. Y indicates "AppleCare+ is consumed"N indicates  "AppleCare+ is not consumed"
        /// </summary>
        [XmlElement(ElementName = "isACPlusConsumed")]
        [StringLength(1, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string IsACPlusConsumed { get; set; }

        /// <summary>
        /// Indicates whether unit is covered by AppleCare+. Possible values are Y N or "" (BLANK).
        /// </summary>
        [XmlElement(ElementName = "acPlusFlag")]
        public string AcPlusFlag { get; set; }

        /// <summary>
        /// Indicates which service type was used for the repair. Possible values are RFD or RPL. RFD indicates refund is consumed RPL indicates replace is consumed
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

        /// <summary>
        /// Indicates the repair failure reason notes added by the Repair vendor.
        /// </summary>
        [XmlElement(ElementName = "repairFailureNotes")]
        [StringLength(500, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string RepairFailureNotes { get; set; }

        /// <summary>
        /// Return Repaired Unit To Customer.
        /// </summary>
        [XmlElement(ElementName = "returnRepairedUnitToCustomer")]
        [StringLength(1, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string ReturnRepairedUnitToCustomer { get; set; }

        /// <summary>
        /// Questions which are answered while creating repair
        // /// </summary>
        // [XmlElement(ElementName = "questions")]
        // public Questions Questions { get; set; }
    }
}