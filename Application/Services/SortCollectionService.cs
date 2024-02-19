using Application.Handlers.CollectionBasedHandlers;
using Application.Handlers.CollectionBasedHandlers.SortCollectionHandlers;
using Core.Enums;
using Core.Enums.EntityEnums;
using Core.Exceptions;
using Lib.Data;
using UI;

namespace Application.Services;

public static class SortCollectionService
{
    public static void Run()
    {
        var entity = GetEntityToWorkWith();
        
        switch (entity)
        {
            case EntityToWorkWith.Machine:
                var machineField = GetMachineField();
                var orderMachine = GetSortOrder();
                Storage.SortMachineCollection(machineField, orderMachine);
                break;
            case EntityToWorkWith.Repair:
                int machineId = GetMachineId();
                var repairField = GetRepairField();
                var orderRepair = GetSortOrder();
                Storage.SortRepairsInMachine(machineId, repairField, orderRepair);
                break;
        }
    }

    private static EntityToWorkWith GetEntityToWorkWith()
    {
        (bool stateEntityChoice, var entity) = (false, EntityToWorkWith.Machine);
        while (!stateEntityChoice)
        {
            (stateEntityChoice, entity) = EntityToWorkWithHandler.Get();
            if (!stateEntityChoice) ConsoleWrapper.WriteException(new WrongEntityToWorkWithException());
        }

        return entity;
    }
    
    private static MachineField GetMachineField()
    {
        (bool stateMachineField, var machineField) = (false, MachineField.MachineId);
        while (!stateMachineField)
        {
            (stateMachineField, machineField) = MachineFieldHandler.Get();
            if (!stateMachineField) ConsoleWrapper.WriteException(new WrongMachineFieldException());
        }

        return machineField;
    }
    
    private static RepairField GetRepairField()
    {
        (bool stateRepairField, var repairField) = (false, RepairField.RepairId);
        while (!stateRepairField)
        {
            (stateRepairField, repairField) = RepairFieldHandler.Get();
            if (!stateRepairField) ConsoleWrapper.WriteException(new WrongRepairFieldException());
        }

        return repairField;
    }
    
    private static SortOrder GetSortOrder()
    {
        (bool stateOrder, var order) = (false, SortOrder.Increase);
        while (!stateOrder)
        {
            (stateOrder, order) = SortOrderHandler.Get();
            if (!stateOrder) ConsoleWrapper.WriteException(new WrongSortOrderException());
        }

        return order;
    }
    
    private static int GetMachineId()
    {
        (bool stateId, int id) = (false, 1);
        while (!stateId)
        {
            (stateId, id) = MachineIdHandler.Get();
            if (!stateId) ConsoleWrapper.WriteException(new WrongMachineId());
        }

        return id;
    }
}