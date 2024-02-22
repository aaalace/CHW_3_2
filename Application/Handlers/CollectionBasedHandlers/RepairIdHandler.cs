using Lib.Data;
using UI;

namespace Application.Handlers.CollectionBasedHandlers;

public static class RepairIdHandler
{
    public static (bool, string) Get(int machineId)
    {
        var currentMachine =
            Storage.machineCollection.Value.FirstOrDefault(x => x.MachineId == machineId);

        if (currentMachine is null) return (false, string.Empty);

        var currentRepairsIdCollection =
            currentMachine.Repairs.Select(x => x.RepairId).ToList();

        ConsoleWrapper.WriteLine($"Choose repair id (from machine with {machineId} id):");
        ConsoleWrapper.WriteLine(string.Join(" | ", currentRepairsIdCollection), ConsoleColor.DarkCyan);

        var s = ConsoleWrapper.ReadLine();
        if (s is null) return (false, string.Empty);

        return currentRepairsIdCollection.Contains(s) ? (true, s) : (false, s);
    }
}