using Lib.Entities;

namespace Lib.Utils;

public static class IdGenerator
{
    public static string GetId(Machine machine)
    {
        var currentRepairsIdCollection =
            machine.Repairs.Select(x => x.RepairId).ToList();

        var maxId =
            currentRepairsIdCollection.Select(x => Convert.ToInt32(x.Split('-')[^1])).Max();
        
        return $"R{machine.MachineId}-{maxId + 1}";
    }
}