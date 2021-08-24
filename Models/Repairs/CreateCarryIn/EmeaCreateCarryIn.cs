using System.Xml.Serialization;
using Cosmos.Models.Core;

namespace Cosmos.Models.Repairs
{
    [XmlRoot("emeaCreateCarryIn")]
    public class EmeaCreateCarryIn : Wrapper 
    {
        public CreateCarryInRequest CreateCarryInRequest { get; set; }
    }
}