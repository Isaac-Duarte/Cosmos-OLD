using System.Collections.Specialized;

namespace Cosmos.Models.Core
{
	public class Wrapper 
	{
		public NameValueCollection Attributes { get; set; }
		public int ColonCutOffset = 0;
		public string ClassName { get; set; }
	}
}