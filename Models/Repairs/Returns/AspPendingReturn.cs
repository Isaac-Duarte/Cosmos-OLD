using System.Xml.Serialization;
using Cosmos.Models.Core;

namespace Cosmos.Models.Returns
{
    [XmlRoot("aspPartsPendingReturn")]
    public class AspPendingReturn : Wrapper 
    {
        [XmlElement(ElementName = "PartsPendingReturn")]
        public PendingReturnRequest PendingReturnRequest { get; set; }
    }
}