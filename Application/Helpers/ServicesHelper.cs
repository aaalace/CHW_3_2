using Application.Handlers.CollectionBasedHandlers;
using Application.Handlers.CollectionBasedHandlers.EditEntityHandlers;
using Application.Handlers.CollectionBasedHandlers.SortCollectionHandlers;
using Application.Handlers.CollectionBasedHandlers.TypeHandlers;
using Core.Enums;
using Core.Enums.EntityEnums;
using Core.Exceptions;
using UI;

namespace Application.Helpers;

public static class ServicesHelper
{
    /// <summary>
    /// Choice of Machine or Repair.
    /// </summary>
    public static EntityToWorkWith GetEntityToWorkWith()
    {
        (bool stateEntityChoice, var entity) = (false, EntityToWorkWith.Machine);
        while (!stateEntityChoice)
        {
            (stateEntityChoice, entity) = EntityToWorkWithHandler.Get();
            if (!stateEntityChoice) ConsoleWrapper.WriteException(new WrongEntityToWorkWithException());
        }

        return entity;
    }
    
    /// <summary>
    /// Choice of field of Machine.
    /// </summary>
    public static MachineField GetMachineField(bool withId)
    {
        (bool stateMachineField, var machineField) = (false, MachineField.MachineId);
        while (!stateMachineField)
        {
            (stateMachineField, machineField) = MachineFieldHandler.Get(withId);
            if (!stateMachineField) ConsoleWrapper.WriteException(new WrongMachineFieldException());
        }

        return machineField;
    }
    
    /// <summary>
    /// Choice of field of Repair.
    /// </summary>
    public static RepairField GetRepairField(bool withId)
    {
        (bool stateRepairField, var repairField) = (false, RepairField.RepairId);
        while (!stateRepairField)
        {
            (stateRepairField, repairField) = RepairFieldHandler.Get(withId);
            if (!stateRepairField) ConsoleWrapper.WriteException(new WrongRepairFieldException());
        }

        return repairField;
    }
    
    /// <summary>
    /// Choice of sort order.
    /// </summary>
    public static SortOrder GetSortOrder()
    {
        (bool stateOrder, var order) = (false, SortOrder.Increase);
        while (!stateOrder)
        {
            (stateOrder, order) = SortOrderHandler.Get();
            if (!stateOrder) ConsoleWrapper.WriteException(new WrongSortOrderException());
        }

        return order;
    }
    
    /// <summary>
    /// Choice of Machine id.
    /// </summary>
    public static int GetMachineId()
    {
        (bool stateId, int id) = (false, 0);
        while (!stateId)
        {
            (stateId, id) = MachineIdHandler.Get();
            if (!stateId) ConsoleWrapper.WriteException(new WrongMachineId());
        }

        return id;
    }
    
    /// <summary>
    /// Choice of Repair id.
    /// </summary>
    public static string GetRepairId(int machineId)
    {
        (bool stateId, string id) = (false, string.Empty);
        while (!stateId)
        {
            (stateId, id) = RepairIdHandler.Get(machineId);
            if (!stateId) ConsoleWrapper.WriteException(new WrongRepairId());
        }

        return id;
    }

    /// <summary>
    /// Choice for machine edit service process.
    /// </summary>
    public static EditFieldOrAddRepair EditFieldOrAddRepair()
    {
        (bool stateId, var option) = (false, Core.Enums.EditFieldOrAddRepair.EditField);
        while (!stateId)
        {
            (stateId, option) = EditFieldOrAddRepairHandler.Get();
            if (!stateId) ConsoleWrapper.WriteException(new WrongOptionException());
        }

        return option;
    }

    public static string GetStringValue(string fieldName)
    {
        (bool stateId, string value) = (false, string.Empty);
        while (!stateId)
        {
            (stateId, value) = StringHandler.Get(fieldName);
            if (!stateId) ConsoleWrapper.WriteException(new WrongTypeException());
        }

        return value;
    }
    
    public static int GetIntValue(string fieldName)
    {
        (bool stateId, int value) = (false, 0);
        while (!stateId)
        {
            (stateId, value) = IntHandler.Get(fieldName);
            if (!stateId) ConsoleWrapper.WriteException(new WrongTypeException());
        }

        return value;
    }
    
    public static double GetDoubleValue(string fieldName)
    {
        (bool stateId, double value) = (false, 0);
        while (!stateId)
        {
            (stateId, value) = DoubleHandler.Get(fieldName);
            if (!stateId) ConsoleWrapper.WriteException(new WrongTypeException());
        }

        return value;
    }

    public static bool GetBoolValue(string fieldName)
    {
        (bool stateId, bool value) = (false, false);
        while (!stateId)
        {
            (stateId, value) = BoolHandler.Get(fieldName);
            if (!stateId) ConsoleWrapper.WriteException(new WrongTypeException());
        }

        return value;
    }
    
    public static DateTime GetDtValue(string fieldName)
    {
        (bool stateId, var value) = (false, new DateTime());
        while (!stateId)
        {
            (stateId, value) = DateHandler.Get(fieldName);
            if (!stateId) ConsoleWrapper.WriteException(new WrongTypeException());
        }

        return value;
    }
}