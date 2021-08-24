using System.Xml.Serialization;

namespace Cosmos.Models.Repairs
{
    [XmlRoot("orderLines")]
    public class OrderLines 
    {
        [XmlElement(ElementName = "partNumber")]
        public string PartNumber { get; set; }

        [XmlElement(ElementName = "comptiaCode")]
        public string ComptiaCode { get; set; }

        [XmlElement(ElementName = "comptiaModifier")]
        public string ComptiaModifier { get; set; }

        [XmlElement(ElementName = "abused")]
        public string Abused { get; set; }

        [XmlElement(ElementName = "returnableDamage")]
        public string ReturnableDamage { get; set; }

        [XmlElement(ElementName = "coveredByACPlus")]
        public string CoveredByACPlus { get; set; }

        [XmlElement(ElementName = "diagnosticCode")]
        public string DiagnosticCode { get; set; }

        [XmlElement(ElementName = "consignmentFlag")]
        public string ConsignmentFlag { get; set; }

        [XmlElement(ElementName = "actualPartUsed")]
        public string ActualPartUsed { get; set; }

        [XmlElement(ElementName = "replacementSerialNumber")]
        public string ReplacementSerialNumber { get; set; }

        [XmlElement(ElementName = "replacementIMEINumber")]
        public string ReplacementIMEINumber { get; set; }
    }
}