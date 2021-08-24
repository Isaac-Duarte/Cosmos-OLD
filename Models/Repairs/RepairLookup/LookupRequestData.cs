using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Cosmos.Models.Repairs
{
    [XmlRoot("lookupRequestData")]
    public class LookupRequestData
    {
        /// <summary>
    /// Serial number
    /// </summary>
    [XmlElement(ElementName = "serialNumber")]
    [StringLength(18, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
    public string SerialNumber { get; set; }

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
    /// Repair status. Click to see the list of Valid Repair Status
    /// </summary>
    [XmlElement(ElementName = "repairStatus")]
    [StringLength(10, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
    public string RepairStatus { get; set; }

    /// <summary>
    /// Repair type. Click to see the list of Valid Repair Types
    /// </summary>
    [XmlElement(ElementName = "repairType")]
    [StringLength(2, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
    public string RepairType { get; set; }

    /// <summary>
    /// Purchase order number
    /// </summary>
    [XmlElement(ElementName = "purchaseOrderNumber")]
    [StringLength(35, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
    public string PurchaseOrderNumber { get; set; }

    /// <summary>
    /// Technician first name
    /// </summary>
    [XmlElement(ElementName = "technicianFirstName")]
    [StringLength(40, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
    public string TechnicianFirstName { get; set; }

    /// <summary>
    /// Technician last name
    /// </summary>
    [XmlElement(ElementName = "technicianLastName")]
    [StringLength(40, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
    public string TechnicianLastName { get; set; }

    /// <summary>
    /// Ship to code
    /// </summary>
    [XmlElement(ElementName = "shipToCode")]
    [StringLength(10, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
    public string ShipToCode { get; set; }

    /// <summary>
    /// Sold to reference number
    /// </summary>
    [XmlElement(ElementName = "soldToReferenceNumber")]
    [StringLength(10, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
    public string SoldToReferenceNumber { get; set; }

    /// <summary>
    /// Indicates if the repair is incomplete. The possible values are Y or N
    /// </summary>
    [XmlElement(ElementName = "incompleteRepair")]
    [StringLength(1, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
    public string IncompleteRepair { get; set; }

    /// <summary>
    /// Indicates if part shipment is pending. The possible values are Y or N
    /// </summary>
    [XmlElement(ElementName = "pendingShipment")]
    [StringLength(1, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
    public string PendingShipment { get; set; }

    /// <summary>
    /// Un-received modules. The possible values are Y or N
    /// </summary>
    [XmlElement(ElementName = "unreceivedModules")]
    [StringLength(1, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
    public string UnreceivedModules { get; set; }

    /// <summary>
    /// Repair creating from date. See all values for Supported Date Formats
    /// </summary>
    [XmlElement(ElementName = "fromDate")]
    public string FromDate { get; set; }

    /// <summary>
    /// Repair creating to date. See all values for Supported Date Formats
    /// </summary>
    [XmlElement(ElementName = "toDate")]
    public string ToDate { get; set; }

    /// <summary>
    /// Customer first name
    /// </summary>
    [XmlElement(ElementName = "customerFirstName")]
    [StringLength(96, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
    public string CustomerFirstName { get; set; }

    /// <summary>
    /// Customer last name
    /// </summary>
    [XmlElement(ElementName = "customerLastName")]
    [StringLength(96, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
    public string CustomerLastName { get; set; }

    /// <summary>
    /// Customer email address
    /// </summary>
    [XmlElement(ElementName = "customerEmailAddress")]
    [StringLength(241, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
    public string CustomerEmailAddress { get; set; }
    }
}