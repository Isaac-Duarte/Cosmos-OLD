using System.Threading.Tasks;
using Cosmos.Models;
using Cosmos.Models.Authentication;
using Cosmos.Models.Core;
using static Cosmos.Services.GSXService;

namespace Cosmos.Services
{
    public partial class GSXService 
    {
		/// <summary>
		/// Authenticates a user and returns a session Id
		/// </summary>
		/// <param name="userId"></param>
		/// <returns></returns>
		public async Task<string> AuthenticateAsync(AuthenticateRequest authenticateRequest) 
		{
			var res = await ExecuteAsync<AuthenticateResponse>(
				new GlobAuthenticate {
					ColonCutOffset = 4,
					AuthenticateRequest = authenticateRequest
				},
				Envelope.Global,
				"Authenticate");

			userSessionId = res.userSessionId;

			return
				res != null
					? res.userSessionId
					: null;
		}
    }
}