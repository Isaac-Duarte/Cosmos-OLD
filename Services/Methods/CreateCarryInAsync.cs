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
        public async Task<CreateCarryInResponse> CreateCarryInAsync(CarryInRepairData repairData) {
            return await ExecuteAsync<CreateCarryInResponse>(
                new EmeaCreateCarryIn {
                    ColonCutOffset = 4,
                    CreateCarryInRequest = new CreateCarryInRequest {
                        UserSession = new UserSession {
                            UserSessionId = userSessionId
                        },
                        RepairData = repairData
                    }
                },
                Envelope.EMEA,
                "CreateCarryIn");
        }
	}
}