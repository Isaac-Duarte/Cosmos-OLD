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
        public async Task<LookupRepairReponse> RepairLookupAsync(LookupRequestData lookupRequestData) {
            return await ExecuteAsync<LookupRepairReponse>(
                new AspLookupRepair {
                    ColonCutOffset = 3,
                    LookupRepairRequest = new LookupRepairRequest {
                        UserSession = new UserSession {
                            UserSessionId = userSessionId
                        },
                        LookupRequestData = lookupRequestData
                    },
                },
                Envelope.ASP,
                "RepairLookup");
        }
	}
}