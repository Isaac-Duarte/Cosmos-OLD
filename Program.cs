using System;
using System.Threading.Tasks;
using Cosmos.Models;
using Cosmos.Models.Authentication;
using Cosmos.Models.Repairs;
using Cosmos.Models.Returns;
using Cosmos.Services;

namespace Cosmos
{
    class Program
    {
        static async Task Main(string[] args)
        {
            GSXService service = new GSXService("http://localhost:8080", "cert.pem", "password");
            
            AuthenticateRequest authenticateRequest = new AuthenticateRequest()
            {
                UserId = "isaac.duarte@simplymac.com",
                LanguageCode = "en",
                UserTimeZone = "EST",
                ServiceAccountNo = "1231231213"
            };

            await service.AuthenticateAsync(authenticateRequest);

            LookupRepairReponse repairs = await service.RepairLookupAsync(new LookupRequestData {
                RepairStatus = "In Repair"
            });
            
            foreach (RepairLookup repairLookup in repairs.LookupResponseData.RepairLookup)
            {
                RepairDetailsResponse repairDetails = await service.RepairDetailsLookupAsync($"G{repairLookup.RepairConfirmationNumber}");

                Console.WriteLine(repairDetails.RepairDetailsResponseData.ProductName);


                Console.WriteLine(repairDetails.RepairDetailsResponseData.PartsInfo[0].OrderNumber);
            }

            var repairData = new PendingReturnRepairData
            {
                RepairStatus = "In Repair"
            };

            var pendingReturns = await service.PendingReturnsAsync(repairData);

        }
    }
}
