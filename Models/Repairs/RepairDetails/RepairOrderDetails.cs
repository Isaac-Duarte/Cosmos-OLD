using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Cosmos.Models.Repairs
{
    public class RepairOrderDetails
    {
        /// <summary>
        /// Part #
        /// </summary>
        [XmlElement(ElementName = "partNumber")]
        [StringLength(18, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string PartNumber { get; set; }

        /// <summary>
        /// Part Description
        /// </summary>
        [XmlElement(ElementName = "partDescription")]
        [StringLength(100, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string PartDescription { get; set; }

        /// <summary>
        /// Part type
        /// </summary>
        [XmlElement(ElementName = "partType")]
        [StringLength(15, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string PartType { get; set; }

        /// <summary>
        /// Net Price
        /// </summary>
        [XmlElement(ElementName = "netPrice")]
        [StringLength(22, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string NetPrice { get; set; }

        /// <summary>
        /// Currency
        /// </summary>
        [XmlElement(ElementName = "currency")]
        [StringLength(5, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string Currency { get; set; }

        /// <summary>
        /// Pricing Option
        /// </summary>
        [XmlElement(ElementName = "pricingOption")]
        [StringLength(10, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string PricingOption { get; set; }

        /// <summary>
        /// Pricing Option Desc
        /// </summary>
        [XmlElement(ElementName = "pricingOptionDesc")]
        [StringLength(100, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string PricingOptionDesc { get; set; }

        /// <summary>
        /// Part Coverage Description
        /// </summary>
        [XmlElement(ElementName = "partCoverageDescription")]
        [StringLength(35, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string PartCoverageDescription { get; set; }

        /// <summary>
        /// CompTIA Code
        /// </summary>
        [XmlElement(ElementName = "comptiaCode")]
        [StringLength(3, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string ComptiaCode { get; set; }

        /// <summary>
        /// CompTIA Modifier
        /// </summary>
        [XmlElement(ElementName = "comptiaModifier")]
        [StringLength(1, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string ComptiaModifier { get; set; }

        /// <summary>
        /// Expected Ship Date
        /// </summary>
        [XmlElement(ElementName = "expectedShipDate")]
        public string ExpectedShipDate { get; set; }

        /// <summary>
        /// Order Status
        /// </summary>
        [XmlElement(ElementName = "orderStatus")]
        [StringLength(10, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// Return Tracking #
        /// </summary>
        [XmlElement(ElementName = "returnTrackingNumber")]
        [StringLength(35, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string ReturnTrackingNumber { get; set; }

        /// <summary>
        /// Return Order #
        /// </summary>
        [XmlElement(ElementName = "returnOrderNumber")]
        [StringLength(10, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string ReturnOrderNumber { get; set; }

        /// <summary>
        /// Return Status
        /// </summary>
        [XmlElement(ElementName = "returnStatus")]
        [StringLength(4, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string ReturnStatus { get; set; }

        /// <summary>
        /// Return Code
        /// </summary>
        [XmlElement(ElementName = "returnCode")]
        [StringLength(4, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string ReturnCode { get; set; }

        /// <summary>
        /// Return Part Received Date
        /// </summary>
        [XmlElement(ElementName = "returnPartReceivedDate")]
        public string ReturnPartReceivedDate { get; set; }

        /// <summary>
        /// Order #
        /// </summary>
        [XmlElement(ElementName = "orderNumber")]
        [StringLength(12, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string OrderNumber { get; set; }

        /// <summary>
        /// Order Line #
        /// </summary>
        [XmlElement(ElementName = "orderLineNumber")]
        [StringLength(3, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string OrderLineNumber { get; set; }

        /// <summary>
        /// Delivery #
        /// </summary>
        [XmlElement(ElementName = "deliveryNumber")]
        [StringLength(10, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string DeliveryNumber { get; set; }

        /// <summary>
        /// Delivery Tracking #
        /// </summary>
        [XmlElement(ElementName = "deliveryTrackingNumber")]
        [StringLength(35, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string DeliveryTrackingNumber { get; set; }

        /// <summary>
        /// Delivery Date
        /// </summary>
        [XmlElement(ElementName = "deliveryDate")]
        public string DeliveryDate { get; set; }

        /// <summary>
        /// Substitute Part #
        /// </summary>
        [XmlElement(ElementName = "substitutePartNumber")]
        [StringLength(18, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string SubstitutePartNumber { get; set; }

        /// <summary>
        /// Order Status Code
        /// </summary>
        [XmlElement(ElementName = "orderStatusCode")]
        [StringLength(5, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string OrderStatusCode { get; set; }

        /// <summary>
        /// Order Status Date
        /// </summary>
        [XmlElement(ElementName = "orderStatusDate")]
        public string OrderStatusDate { get; set; }

        /// <summary>
        /// Carrier Code
        /// </summary>
        [XmlElement(ElementName = "carrierCode")]
        [StringLength(18, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string CarrierCode { get; set; }

        /// <summary>
        /// Carrier Name
        /// </summary>
        [XmlElement(ElementName = "carrierName")]
        [StringLength(100, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string CarrierName { get; set; }

        /// <summary>
        /// Carrier URL
        /// </summary>
        [XmlElement(ElementName = "carrierURL")]
        [StringLength(256, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string CarrierURL { get; set; }

        /// <summary>
        /// Old Serial number. It was used to capture KBB serial number
        /// </summary>
        [XmlElement(ElementName = "oldSerialNumber")]
        [StringLength(18, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string OldSerialNumber { get; set; }

        /// <summary>
        /// New Serial number. It was used to capture KGB serial number
        /// </summary>
        [XmlElement(ElementName = "serialNumber")]
        [StringLength(18, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Serialized Flag. Possible values are Y or N
        /// </summary>
        [XmlElement(ElementName = "isSerialized")]
        [StringLength(1, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string IsSerialized { get; set; }

        /// <summary>
        /// Original Part Number
        /// </summary>
        [XmlElement(ElementName = "originalPartNumber")]
        [StringLength(18, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string  OriginalPartNumber { get; set; }
    }
}