using System.Text.Json.Serialization;

namespace Lib.Entities;

public class Repair
{
    [JsonPropertyName("repair_id")]
    public string RepairId { get; set; }

    [JsonPropertyName("issue")]
    public string Issue { get; set; }

    [JsonPropertyName("repair_cost")]
    public decimal RepairCost { get; set; }

    [JsonPropertyName("technician")]
    public string Technician { get; set; }

    [JsonPropertyName("is_fixed")]
    public bool IsFixed { get; set; }

    [JsonPropertyName("repair_date")]
    public DateTime RepairDate { get; set; }
    
    [JsonConstructor]
    public Repair(string repairId, string issue,
        decimal repairCost, string technician,
        bool isFixed, DateTime repairDate)
    {
        RepairId = repairId;
        Issue = issue;
        RepairCost = repairCost;
        Technician = technician;
        IsFixed = isFixed;
        RepairDate = repairDate;
    }
    
    public string ToJSON()
    {
        return string.Empty;
    }
}