
using System.Xml.Serialization;
using Cosmos.Models.Customer;

namespace Cosmos.Models.Repairs
{
    [XmlRoot("repairData")]
    public class CarryInRepairData 
    {
        [XmlElement(ElementName = "billTo")]
        public string BillTo { get; set; }

        [XmlElement(ElementName = "checkIfOutOfWarrantyCoverage")]
        public string CheckIfOutOfWarrantyCoverage { get; set; }

        [XmlElement(ElementName = "customerAddress")]
        public CustomerAddress CustomerAddress { get; set; }

        [XmlElement(ElementName = "diagnosedByTechId")]
        public string DiagnosedByTechId { get; set; }

        [XmlElement(ElementName = "diagnosis")]
        public string Diagnosis { get; set; }

        [XmlElement(ElementName = "fileName")]
        public string FileName { get; set; }

        [XmlElement(ElementName = "fileData")]
        public string FileData { get; set; }

        [XmlElement(ElementName = "isNonReplenished")]
        public string IsNonReplenished { get; set; }

        [XmlElement(ElementName = "notes")]
        public string Notes { get; set; }

        [XmlElement(ElementName = "orderLines")]
        public OrderLines[] OrderLines { get; set; }

        [XmlElement(ElementName = "componentCheckDetails")]
        public ComponentCheckDetails[] ComponentCheckDetails { get; set; }

        [XmlElement(ElementName = "overrideDiagnosticCodeCheck")]
        public string OverrideDiagnosticCodeCheck { get; set; }

        [XmlElement(ElementName = "poNumber")]
        public string PoNumber { get; set; }

        [XmlElement(ElementName = "popFaxed")]
        public string PopFaxed { get; set; }

        [XmlElement(ElementName = "referenceNumber")]
        public string ReferenceNumber { get; set; }

        [XmlElement(ElementName = "requestReviewByApple")]
        public string RequestReviewByApple { get; set; }

        [XmlElement(ElementName = "serialNumber")]
        public string serialNumber { get; set; }

        [XmlElement(ElementName = "repairData")]
        public string shipTo { get; set; }

        [XmlElement(ElementName = "repairData")]
        public string symptom { get; set; }

        [XmlElement(ElementName = "repairData")]
        public string unitReceivedDate { get; set; }

        [XmlElement(ElementName = "repairData")]
        public string unitReceivedTime { get; set; }

        [XmlElement(ElementName = "repairData")]
        public string markCompleteFlag { get; set; }

        [XmlElement(ElementName = "repairData")]
        public string replacementSerialNumber { get; set; }

        [XmlElement(ElementName = "repairData")]
        public string componentCheckReview { get; set; }

        [XmlElement(ElementName = "repairData")]
        public string serviceType { get; set; }

        [XmlElement(ElementName = "repairData")]
        public string shipBox { get; set; }

        [XmlElement(ElementName = "repairData")]
        public string consumerLawEligible { get; set; }

        [XmlElement(ElementName = "repairData")]
        public string reportedSymptomCode { get; set; }

        [XmlElement(ElementName = "repairData")]
        public string reportedIssueCode { get; set; }

        [XmlElement(ElementName = "repairData")]
        public string dataTransferRequired { get; set; }

        [XmlElement(ElementName = "repairData")]
        public string comptiaCode { get; set; }

        [XmlElement(ElementName = "repairData")]
        public string comptiaModifier { get; set; }
    }
}