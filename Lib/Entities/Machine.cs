using System.Text.Json.Serialization;

namespace Lib.Entities;

public partial class Machine
{
    [JsonPropertyName("machine_id")]
    public int MachineId { get; }

    [JsonPropertyName("brand")]
    public string Brand { get; private set; }

    [JsonPropertyName("model")]
    public string Model { get; private set; }

    [JsonPropertyName("year")]
    public int Year { get; private set; }

    [JsonPropertyName("price")]
    public double Price { get; private set; }

    [JsonPropertyName("is_ready")]
    public bool IsReady { get; set; }

    [JsonPropertyName("repairs")]
    public List<Repair> Repairs { get; set; }
    
    [JsonConstructor]
    public Machine(int machineId, string brand, string model,
        int year, double price, bool isReady,
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
}