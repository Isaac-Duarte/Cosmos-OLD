using System.Threading.Tasks;
using System.Xml.Serialization;
using Cosmos.Models;
using Cosmos.Models.Core;
using Cosmos.Models.Repairs;
using Cosmos.Models.Returns;
using static Cosmos.Services.GSXService;

namespace Cosmos.Services
{
    public partial class GSXService 
    {
        public async Task<PendingReturnResponse> PendingReturnsAsync(PendingReturnRepairData repairData) {
            return await ExecuteAsync<PendingReturnResponse>(
                new AspPendingReturn {
                    ColonCutOffset = 3,
                    PendingReturnRequest = new PendingReturnRequest {
                        UserSession = new UserSession {
                            UserSessionId = userSessionId
                        },
                       PendingReturnRepairData = repairData
                    },
                },
                Envelope.ASP,
                "PartsPendingReturn");
        }
	}
}