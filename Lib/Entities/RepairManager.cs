using Lib.CustomEventArgs;
using Lib.Data;
using UI;

namespace Lib.Entities;

public class RepairManager
{
    public void OnRepairChangedHandler(object? sender, RepairChangedEventArgs args)
    {
        if (!args.Machine.Repairs.All(x => x.IsFixed)) return;
        
        int machineId = args.Machine.MachineId;
        var machine = Storage.machineCollection.Value.FirstOrDefault(x => x.MachineId == machineId);
        if (machine == null) return;
        
        machine.IsReady = true;
        ConsoleWrapper.WriteLine($"Machine {machineId} is ready", ConsoleColor.DarkCyan);
    }
}