using System.Threading.Tasks;
using System.Xml.Serialization;
using Cosmos.Models;
using Cosmos.Models.Core;
using Cosmos.Models.Repairs;
using static Cosmos.Services.GSXService;

namespace Cosmos.Services
{
    public partial class GSXService 
    {
        public async Task<RepairDetailsResponse> RepairDetailsLookupAsync(string dispatchId) {
            return await ExecuteAsync<RepairDetailsResponse>(
                new AspRepairDetailsLookup {
                    ColonCutOffset = 3,
                    RepairDetailsRequest = new RepairDetailsRequest {
                        UserSession = new UserSession {
                            UserSessionId = userSessionId
                        },
                       DispatchId = dispatchId
                    },
                },
                Envelope.ASP,
                "RepairDetails");
        }
	}
}