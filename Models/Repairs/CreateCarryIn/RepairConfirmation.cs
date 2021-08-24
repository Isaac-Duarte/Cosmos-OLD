using System.Xml.Serialization;

namespace Cosmos.Models.Repairs
{
    [XmlRoot("repairConfirmation")]
    public class RepairConfirmation 
    {
        [XmlElement(ElementName = "confirmationNumber")]
        public string ConfirmationNumber { get; set; }

        [XmlElement(ElementName = "diagnosticDescription")]
        public string DiagnosticDescription { get; set; }

        [XmlElement(ElementName = "diagnosticEventNumber")]
        public string DiagnosticEventNumber { get; set; }

        [XmlElement(ElementName = "diagnosticEventEndResult")]
        public string DiagnosticEventEndResult { get; set; }

        [XmlElement("parts", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Parts[] Parts { get; set; }
        
        [XmlElement(ElementName = "totalFromOrder")]
        public string TotalFromOrder { get; set; }

        [XmlElement(ElementName = "icmsTax")]
        public string IcmsTax { get; set; }

        [XmlElement(ElementName = "pisTax")]
        public string PisTax { get; set; }
        
        [XmlElement(ElementName = "ipiTax")]
        public string IpiTax { get; set; }

        [XmlElement(ElementName = "icmsStTax")]
        public string IcmsStTax { get; set; }

        [XmlElement(ElementName = "cofinsTax")]
        public string CofinsTax { get; set; }

        [XmlElement(ElementName = "issTax")]
        public string IssTax { get; set; }

        [XmlElement(ElementName = "vatTax")]
        public string VatTax { get; set; }

        [XmlElement(ElementName = "outcome")]
        public string Outcome { get; set; }

        [XmlElement("messages", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] messages { get; set; }

        [XmlElement(ElementName = "availableRepairStrategies")]
        public AvailableRepairStrategies AvailableRepairStrategies { get; set; }
    }
}