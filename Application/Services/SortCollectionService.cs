using Application.Helpers;
using Core.Enums.EntityEnums;
using Lib.Data;

namespace Application.Services;

public static class SortCollectionService
{
    public static void Run()
    {
        var entity = ServicesHelper.GetEntityToWorkWith();
        
        switch (entity)
        {
            case EntityToWorkWith.Machine:
                MachineSortProcess();
                break;
            case EntityToWorkWith.Repair:
                RepairsSortProcess();
                break;
        }
    }

    private static void MachineSortProcess()
    {
        var machineField = ServicesHelper.GetMachineField(withId: true);
        var orderMachine = ServicesHelper.GetSortOrder();
        Storage.SortMachineCollection(machineField, orderMachine);
    }
    
    private static void RepairsSortProcess()
    {
        int machineId = ServicesHelper.GetMachineId();
        var repairField = ServicesHelper.GetRepairField(withId: true);
        var orderRepair = ServicesHelper.GetSortOrder();
        Storage.SortRepairsInMachine(machineId, repairField, orderRepair);
    }
}