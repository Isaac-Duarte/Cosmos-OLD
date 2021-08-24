#!/usr/bin/env dotnet-script

//  Usage
// Copy HTML Table
//  Convert to CSV (https://www.convertcsv.com/html-table-to-csv.htm)

using System;
using System.Collections.Generic;

string data = @"returnOrderNumber,The return order number for the part.,String,10,--
purchaseOrderNumber,The purchase order number for the part.,String,35,--
referenceNumber,The reference number for the part.,String,35,--
sroNumber,The repair number for the part.,String,12,--
repairConfirmationNumber,The confirmation number for the part.,String,15,--
partNumber,The part number for the part.,String,18,--
partDescription,The description of the part or unit.,String,100,--
shipToCode,Ship-to code,String,10,--
expectedReturn,Expected return,String,3,--
expectedReturnDate,Expected return date,String,†,--
registeredForReturn,Registered for return indicator,String,3,--
returnLabelPrinted,Return Label printed indicator,String,3,--
warrantyStatus,Warranty Status,String,25,--
serialNumber,Serial number,String,18,--
comptiaCode,comptia Code,String,3,--
kbbSerialNumber,KBBSerialNumber,String,18,--
vendorName*,Vendor Name,String,96,--
vendorAddress*,Vendor Address,String,240,--
vendorState*,Vendor State,String,3,--
vendorCity*,Vendor City,String,40,--
batteryNetWeight,Battery Net Weight (in Kg),String,10,--
dangerousGoods,Dangerous Goods,String,18,--";

public class Entity
{
    public string Parameter { get; set; }
    public string Description { get; set; }
    public string Type { get; set; }
    public int MaxLength { get; set; }
    public bool Required { get; set; }

    public static List<Entity> FromCsv(string csv)
    {
        List<Entity> entities = new List<Entity>();

        foreach (string line in csv.Split('\n'))
        {
            Entity entity = new Entity();

            string[] columns = line.Split(',');

            for (int i = 0; i < columns.Length; i++)
            {
                string data = columns[i];

                switch (i)
                {
                    // Parameter
                    case 0:
                        entity.Parameter = data;
                        break;
                    
                    // Description
                    case 1:
                        entity.Description = data;
                        break;
                    
                    // Type
                    case 2:
                        entity.Type = data.ToLower();
                        break;
                    
                    // MaxLength
                    case 3:
                        if (data == "NA" | data == "0x2020")
                        {
                            entity.MaxLength = 0;
                        }
                        else
                        {
                            try
                            {
                                int maxLength = Convert.ToInt32(data);
                                entity.MaxLength = maxLength;
                            }
                            catch
                            {
                                entity.MaxLength = 0;
                            }
                        }

                        break;
                    
                    // Required
                    case 4:
                        if (data == "No")
                        {
                            entity.Required = false;
                        }
                        else
                        {
                            entity.Required = true;
                        }

                        break;
                    default:
                        break;
                }
            }

            entities.Add(entity);
        }

        return entities;
    }
}

var entities = Entity.FromCsv(data);

foreach (Entity entity in entities)
{
    var maxLengthText = entity.MaxLength > 0 ? $"\n//[StringLength({entity.MaxLength}, ErrorMessage = \"The {{0}} value cannot exceed {{1}} characters. \")]" : "";

    Console.WriteLine($@"/// <summary>
/// {entity.Description}
/// </summary>
[XmlElement(ElementName = ""{entity.Parameter}"")]{maxLengthText}
public {entity.Type} {(entity.Parameter.First().ToString().ToUpper() + entity.Parameter.Substring(1))} {{ get; set; }}
");
}
