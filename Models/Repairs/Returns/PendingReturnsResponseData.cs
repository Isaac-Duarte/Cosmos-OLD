using System.Xml.Serialization;
using Cosmos.Models.Core;

namespace Cosmos.Models.Returns
{
    [XmlRoot(ElementName = "partsPendingResponse")]
    public class PendingReturnsResponseData
    {
        /// <summary>
        /// The return order number for the part.
        /// </summary>
        [XmlElement(ElementName = "returnOrderNumber")]
        //[StringLength(10, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string ReturnOrderNumber { get; set; }

        /// <summary>
        /// The purchase order number for the part.
        /// </summary>
        [XmlElement(ElementName = "purchaseOrderNumber")]
        //[StringLength(35, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string PurchaseOrderNumber { get; set; }

        /// <summary>
        /// The reference number for the part.
        /// </summary>
        [XmlElement(ElementName = "referenceNumber")]
        //[StringLength(35, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// The repair number for the part.
        /// </summary>
        [XmlElement(ElementName = "sroNumber")]
        //[StringLength(12, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string SroNumber { get; set; }

        /// <summary>
        /// The confirmation number for the part.
        /// </summary>
        [XmlElement(ElementName = "repairConfirmationNumber")]
        //[StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string RepairConfirmationNumber { get; set; }

        /// <summary>
        /// The part number for the part.
        /// </summary>
        [XmlElement(ElementName = "partNumber")]
        //[StringLength(18, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string PartNumber { get; set; }

        /// <summary>
        /// The description of the part or unit.
        /// </summary>
        [XmlElement(ElementName = "partDescription")]
        //[StringLength(100, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string PartDescription { get; set; }

        /// <summary>
        /// Ship-to code
        /// </summary>
        [XmlElement(ElementName = "shipToCode")]
        //[StringLength(10, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string ShipToCode { get; set; }

        /// <summary>
        /// Expected return
        /// </summary>
        [XmlElement(ElementName = "expectedReturn")]
        //[StringLength(3, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string ExpectedReturn { get; set; }

        /// <summary>
        /// Expected return date
        /// </summary>
        [XmlElement(ElementName = "expectedReturnDate")]
        public string ExpectedReturnDate { get; set; }

        /// <summary>
        /// Registered for return indicator
        /// </summary>
        [XmlElement(ElementName = "registeredForReturn")]
        //[StringLength(3, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string RegisteredForReturn { get; set; }

        /// <summary>
        /// Return Label printed indicator
        /// </summary>
        [XmlElement(ElementName = "returnLabelPrinted")]
        //[StringLength(3, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string ReturnLabelPrinted { get; set; }

        /// <summary>
        /// Warranty Status
        /// </summary>
        [XmlElement(ElementName = "warrantyStatus")]
        //[StringLength(25, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string WarrantyStatus { get; set; }

        /// <summary>
        /// Serial number
        /// </summary>
        [XmlElement(ElementName = "serialNumber")]
        //[StringLength(18, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string SerialNumber { get; set; }

        /// <summary>
        /// comptia Code
        /// </summary>
        [XmlElement(ElementName = "comptiaCode")]
        //[StringLength(3, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string ComptiaCode { get; set; }

        /// <summary>
        /// KBBSerialNumber
        /// </summary>
        [XmlElement(ElementName = "kbbSerialNumber")]
        //[StringLength(18, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string KbbSerialNumber { get; set; }

        /// <summary>
        /// Vendor Name
        /// </summary>
        [XmlElement(ElementName = "vendorName")]
        //[StringLength(96, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string VendorName { get; set; }

        /// <summary>
        /// Vendor Address
        /// </summary>
        [XmlElement(ElementName = "vendorAddress")]
        //[StringLength(240, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string VendorAddress { get; set; }

        /// <summary>
        /// Vendor State
        /// </summary>
        [XmlElement(ElementName = "vendorState")]
        //[StringLength(3, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string VendorState { get; set; }

        /// <summary>
        /// Vendor City
        /// </summary>
        [XmlElement(ElementName = "vendorCity")]
        //[StringLength(40, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string VendorCity { get; set; }

        /// <summary>
        /// Battery Net Weight (in Kg)
        /// </summary>
        [XmlElement(ElementName = "batteryNetWeight")]
        //[StringLength(10, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string BatteryNetWeight { get; set; }

        /// <summary>
        /// Dangerous Goods
        /// </summary>
        [XmlElement(ElementName = "dangerousGoods")]
        //[StringLength(18, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string DangerousGoods { get; set; }

    }
}