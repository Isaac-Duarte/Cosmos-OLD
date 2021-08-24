# Cosmos
**Just realised the SOAP API got discontinued.**


Work in progress wrapper for the GSX API.  
*This is not a functional libary yet. Still under the works*

## Todo
* ~~Split GSXNextGen into files~~
* ~~Object orient GSXNextGen~~
  * ~~Fix types for default models from gsx-next-gen~~
* ~~Make the WebServiceHandler Async~~
* Implement proper logger via [Serilog](https://serilog.net/)
* Implement session tracking for relogging in. (Implement at request level. Execute)
* Document old code from gsx-next-gen
* Add Unit testing
* Add Proper [enumerations](https://gsxapiut.apple.com/apidocs/ut/html/WSReference.html?user=asp)

<!-- https://www.tablesgenerator.com/markdown_tables -->
## Functionality
##### *Not fully documented*

| Function             | Implemented        |
|----------------------|--------------------|
| Authentication       | :heavy_check_mark: |
| Carry In Repair      | :heavy_check_mark: |
| Repair Lookup        | :heavy_check_mark: |
| Repair Details       | :heavy_check_mark: |
| Parts Pending Return | :heavy_check_mark: |
| Mail In Repair       | :x:                |

## Sample
```cs
GSXService service = new GSXService("http://localhost:8080", "cert.pem", "password");
            
AuthenticateRequest authenticateRequest = new AuthenticateRequest()
{
    UserId = "isaac.duarte@simplymac.com",
    LanguageCode = "EN",
    UserTimeZone = "EST",
    ServiceAccountNo = "1231231213"
};

service.Authenticate(authenticateRequest);

LookupRepairReponse repairs = service.RepairLookup(new LookupRequestData {
    SerialNumber = "C02D64ZTEST"
});

foreach (RepairLookup repairLookup in repairs.LookupResponseData.RepairLookup)
{
    Console.WriteLine($"{repairLookup.RepairNumber} - {repairLookup.CustomerName}");
}
```
## Output
```
11223344 - Jay,Javier Vilanova
78652628 - Jay,Javier Vilanova
```

## Helpers
### [CsvToClass](./Helpers/CsvToClass/main.csx)
This is a helper script that converts request data from the [GSX API Documentation](https://gsxapiut.apple.com/apidocs/ut/html/WSReference.html?user=asp) and helps generate C# Classes. It's very basic and still needs to be slightly modified to produce working code.

## Credits
[nagilum](https://github.com/nagilum/gsx-next-gen) - WebServiceHandler

[filipp](https://github.com/filipp/gsx-mockserver) - Mock server for testing 
