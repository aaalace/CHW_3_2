using Core.Enums.EntityEnums;

namespace Lib.Data;

public partial class Storage
{
    public static void EditMachine<TField>(TField updField, int machineId, MachineField fieldToEdit)
    {
        var machine = machineCollection.Value.FirstOrDefault(x => x.MachineId == machineId);
        machine?.EditMachine(updField, fieldToEdit);
    }
    
    public static void AddRepair(
        int machineId,
        string issue,
        double repairCost,
        string technician,
        bool isFixed,
        DateTime repairDate)
    {
        var machine = machineCollection.Value.FirstOrDefault(x => x.MachineId == machineId);
        machine?.AddRepair(issue, repairCost, technician, isFixed, repairDate);
    }
    
    public static void EditRepair<TField>(TField updField, int machineId, string repairId, RepairField fieldToEdit)
    {
        var machine = machineCollection.Value.FirstOrDefault(x => x.MachineId == machineId);
        machine?.EditRepair(updField, repairId, fieldToEdit);
    }
}