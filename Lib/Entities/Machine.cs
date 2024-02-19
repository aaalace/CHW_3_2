using System.Text.Json.Serialization;

namespace Lib.Entities;

public class Machine
{
    [JsonPropertyName("machine_id")]
    public int MachineId { get; set; }

    [JsonPropertyName("brand")]
    public string Brand { get; set; }

    [JsonPropertyName("model")]
    public string Model { get; set; }

    [JsonPropertyName("year")]
    public int Year { get; set; }

    [JsonPropertyName("price")]
    public decimal Price { get; set; }

    [JsonPropertyName("is_ready")]
    public bool IsReady { get; set; }

    [JsonPropertyName("repairs")]
    public List<Repair> Repairs { get; set; }
    
    [JsonConstructor]
    public Machine(int machineId, string brand, string model,
        int year, decimal price, bool isReady,
        List<Repair> repairs)
    {
        MachineId = machineId;
        Brand = brand;
        Model = model;
        Year = year;
        Price = price;
        IsReady = isReady;
        Repairs = repairs;
    }
    
    public string ToJSON()
    {
        return string.Empty;
    }
}