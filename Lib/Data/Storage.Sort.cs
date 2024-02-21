using Core.Enums;
using Core.Enums.EntityEnums;

namespace Lib.Data;

public partial class Storage
{
    public static void SortMachineCollection(MachineField field, SortOrder order)
    {
        var sortedCollection = field switch
        {
            MachineField.MachineId => machineCollection.Value.OrderBy(x => x.MachineId).ToList(),
            MachineField.Brand => machineCollection.Value.OrderBy(x => x.Brand).ToList(),
            MachineField.Model => machineCollection.Value.OrderBy(x => x.Model).ToList(),
            MachineField.Price => machineCollection.Value.OrderBy(x => x.Price).ToList(),
            MachineField.IsReady => machineCollection.Value.OrderBy(x => x.IsReady).ToList(),
            MachineField.Year => machineCollection.Value.OrderBy(x => x.Year).ToList(),
            _ => machineCollection.Value
        };
        
        if (order == SortOrder.Decrease) sortedCollection.Reverse();

        machineCollection.UpdateCollection(sortedCollection);
    }
    
    public static void SortRepairsInMachine(int machineId, RepairField field, SortOrder order)
    {
        var machine = machineCollection.Value.FirstOrDefault(x => x.MachineId == machineId);
        if (machine is null) return;
        
        var sortedRepairsCollection = field switch
        {
            RepairField.RepairId => machine.Repairs.OrderBy(x => x.RepairId).ToList(),
            RepairField.RepairDate => machine.Repairs.OrderBy(x => x.RepairDate).ToList(),
            RepairField.RepairCost => machine.Repairs.OrderBy(x => x.RepairCost).ToList(),
            RepairField.Issue => machine.Repairs.OrderBy(x => x.Issue).ToList(),
            RepairField.Technician => machine.Repairs.OrderBy(x => x.Technician).ToList(),
            RepairField.IsFixed => machine.Repairs.OrderBy(x => x.IsFixed).ToList(),
            _ => machine.Repairs
        };
        
        if (order == SortOrder.Decrease) sortedRepairsCollection.Reverse();

        machine.Repairs = sortedRepairsCollection;
    }
}