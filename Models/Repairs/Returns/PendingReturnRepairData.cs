using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Cosmos.Models.Returns
{
    [XmlRoot("repairData")]
    public class PendingReturnRepairData
    {
        /// <summary>
        /// Repair Type for which parts have to be searched.
        /// </summary>
        [XmlElement(ElementName = "repairType")]
        [StringLength(2, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string RepairType { get; set; }

        /// <summary>
        /// Repair Status for which parts have to be searched.
        /// </summary>
        [XmlElement(ElementName = "repairStatus")]
        [StringLength(2, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string RepairStatus { get; set; }

        /// <summary>
        /// Purchase order number
        /// </summary>
        [XmlElement(ElementName = "purchaseOrderNumber")]
        [StringLength(35, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string PurchaseOrderNumber { get; set; }

        /// <summary>
        /// Repair number
        /// </summary>
        [XmlElement(ElementName = "sroNumber")]
        [StringLength(12, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string SroNumber { get; set; }

        /// <summary>
        /// Confirmation number
        /// </summary>
        [XmlElement(ElementName = "repairConfirmationNumber")]
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string RepairConfirmationNumber { get; set; }

        /// <summary>
        /// Serial numbers
        /// </summary>
        [XmlElement(ElementName = "serialNumbers")]
        [StringLength(100, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public PendingReturnSerialNumbers[] SerialNumbers { get; set; }

        /// <summary>
        /// Ship-to code
        /// </summary>
        [XmlElement(ElementName = "shipToCode")]
        [StringLength(10, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string ShipToCode { get; set; }

        /// <summary>
        /// Customer's first name
        /// </summary>
        [XmlElement(ElementName = "customerFirstName")]
        [StringLength(96, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string CustomerFirstName { get; set; }

        /// <summary>
        /// Customer's last name
        /// </summary>
        [XmlElement(ElementName = "customerLastName")]
        [StringLength(96, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string CustomerLastName { get; set; }

        /// <summary>
        /// Customer's email address
        /// </summary>
        [XmlElement(ElementName = "customerEmailAddress")]
        [StringLength(256, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string CustomerEmailAddress { get; set; }

        /// <summary>
        /// "The order creation start date. The parts that are pending return will be searched during the given time period based on the order creation date."
        /// </summary>
        [XmlElement(ElementName = "createdFromDate")]
        public string CreatedFromDate { get; set; }

        /// <summary>
        /// The order creation end date.
        /// </summary>
        [XmlElement(ElementName = "createdToDate")]
        public string CreatedToDate { get; set; }

        /// <summary>
        /// Warranty type. Expected values are IW or OW.
        /// </summary>
        [XmlElement(ElementName = "warrantyType")]
        [StringLength(2, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string WarrantyType { get; set; }

        /// <summary>
        /// Expected values are Y or N.
        /// </summary>
        [XmlElement(ElementName = "kbbSerialNumberFlag")]
        [StringLength(1, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string KbbSerialNumberFlag { get; set; }

        /// <summary>
        /// comptia Code
        /// </summary>
        [XmlElement(ElementName = "comptiaCode")]
        [StringLength(3, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string ComptiaCode { get; set; }

        /// <summary>
        /// "Expected values are Y n or blank."
        /// </summary>
        [XmlElement(ElementName = "dangerousGoods")]
        public string DangerousGoods { get; set; }
    }
}