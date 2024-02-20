using Application.Helpers;
using Core.Enums;
using Core.Enums.EntityEnums;
using Lib.Data;

namespace Application.Services;

public static class EditEntityService
{
    public static void Run()
    {
        var entity = ServicesHelper.GetEntityToWorkWith();
        
        switch (entity)
        {
            case EntityToWorkWith.Machine:
                MachineEditProcess();
                break;
            case EntityToWorkWith.Repair:
                RepairEditProcess();
                break;
        }
    }
    
    private static void MachineEditProcess()
    {
        var editFieldOrAddRepair = ServicesHelper.EditFieldOrAddRepair();
        
        switch (editFieldOrAddRepair)
        {
            case EditFieldOrAddRepair.EditField:
                EditMachineFieldProcess();
                break;
            case EditFieldOrAddRepair.AddRepair:
                AddRepairProcess();
                break;
        }
    }
    
    private static void EditMachineFieldProcess()
    {
        int machineId = ServicesHelper.GetMachineId();
        var machineField = ServicesHelper.GetMachineField(withId: false);

        switch (machineField)
        {
            case MachineField.Brand:
            case MachineField.Model:
                string strValue = ServicesHelper.GetStringValue(machineField.ToString());
                Storage.EditMachine(strValue, machineId, machineField);
                break;
            case MachineField.Price:
                double doubleValue = ServicesHelper.GetDoubleValue(machineField.ToString());
                Storage.EditMachine(doubleValue, machineId, machineField);
                break;
            case MachineField.Year:
                int intValue = ServicesHelper.GetIntValue(machineField.ToString());
                Storage.EditMachine(intValue, machineId, machineField);
                break;
            case MachineField.IsReady:
                bool boolValue = ServicesHelper.GetBoolValue(machineField.ToString());
                Storage.EditMachine(boolValue, machineId, machineField);
                break;
        }
    }
    
    private static void AddRepairProcess()
    {
        int machineId = ServicesHelper.GetMachineId();
        
        string issue = ServicesHelper.GetStringValue(RepairField.Issue.ToString());
        double cost = ServicesHelper.GetDoubleValue(RepairField.RepairCost.ToString());
        string technician = ServicesHelper.GetStringValue(RepairField.Technician.ToString());
        bool isFixed = ServicesHelper.GetBoolValue(RepairField.IsFixed.ToString());
        var date = ServicesHelper.GetDtValue(RepairField.RepairDate.ToString());
        
        Storage.AddRepair(machineId, issue, cost, technician, isFixed, date);
    }
    
    private static void RepairEditProcess()
    {
        int machineId = ServicesHelper.GetMachineId();
        string repairId = ServicesHelper.GetRepairId(machineId);
        var repairField = ServicesHelper.GetRepairField(withId: false);

        switch (repairField)
        {
            case RepairField.Issue:
            case RepairField.Technician:
                string strValue = ServicesHelper.GetStringValue(repairField.ToString());
                Storage.EditRepair(strValue, machineId, repairId, repairField);
                break;
            case RepairField.RepairCost:
                double doubleValue = ServicesHelper.GetDoubleValue(repairField.ToString());
                Storage.EditRepair(doubleValue, machineId, repairId, repairField);
                break;
            case RepairField.IsFixed:
                bool boolValue = ServicesHelper.GetBoolValue(repairField.ToString());
                Storage.EditRepair(boolValue, machineId, repairId, repairField);
                break;
            case RepairField.RepairDate:
                var dateValue = ServicesHelper.GetDtValue(repairField.ToString());
                Storage.EditRepair(dateValue, machineId, repairId, repairField);
                break;
        }
    }

}