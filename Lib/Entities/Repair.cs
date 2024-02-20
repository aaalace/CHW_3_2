using System.Text.Json.Serialization;

namespace Lib.Entities;

public partial class Repair
{
    [JsonPropertyName("repair_id")]
    public string RepairId { get; set; }

    [JsonPropertyName("issue")]
    public string Issue { get; set; }

    [JsonPropertyName("repair_cost")]
    public double RepairCost { get; set; }

    [JsonPropertyName("technician")]
    public string Technician { get; set; }

    [JsonPropertyName("is_fixed")]
    public bool IsFixed { get; set; }

    [JsonPropertyName("repair_date")]
    public DateTime RepairDate { get; set; }
    
    [JsonConstructor]
    public Repair(string repairId, string issue,
        double repairCost, string technician,
        bool isFixed, DateTime repairDate)
    {
        RepairId = repairId;
        Issue = issue;
        RepairCost = repairCost;
        Technician = technician;
        IsFixed = isFixed;
        RepairDate = repairDate;
    }
}