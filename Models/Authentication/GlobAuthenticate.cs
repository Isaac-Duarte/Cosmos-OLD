using System.Xml.Serialization;
using Cosmos.Models.Core;

namespace Cosmos.Models.Authentication
{
    [XmlRoot("globAuthenticate")]
    public class GlobAuthenticate : Wrapper 
    {
        public AuthenticateRequest AuthenticateRequest { get; set; }
    }
}