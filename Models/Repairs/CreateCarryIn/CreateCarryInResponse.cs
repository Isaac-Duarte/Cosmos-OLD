using System.Xml.Serialization;

namespace Cosmos.Models.Repairs
{
    public class CreateCarryInResponse 
    {
        [XmlElement(ElementName = "operationId")]
        public string OperationId { get; set; }

        [XmlElement(ElementName = "repairConfirmation")]
        public RepairConfirmation RepairConfirmation { get; set; }
    }
}