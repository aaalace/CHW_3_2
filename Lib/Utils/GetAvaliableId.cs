using Lib.Entities;

namespace Lib.Utils;

/// <summary>
/// Generator of new id for added repair.
/// </summary>
public static class IdGenerator
{
    /// <summary>
    /// Generates new id.
    /// </summary>
    /// <param name="machine">Machine where new repair added.</param>
    /// <returns>New id.</returns>
    public static string GetId(Machine machine)
    {
        var currentRepairsIdCollection =
            machine.Repairs.Select(x => x.RepairId).ToList();

        var maxId =
            currentRepairsIdCollection.Select(x => Convert.ToInt32(x.Split('-')[^1])).Max();
        
        return $"R{machine.MachineId}-{maxId + 1}";
    }
}