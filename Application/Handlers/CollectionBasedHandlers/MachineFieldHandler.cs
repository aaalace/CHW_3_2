﻿using Core.Enums.EntityEnums;
using UI;

namespace Application.Handlers.CollectionBasedHandlers;

public static class MachineFieldHandler
{
    public static (bool, MachineField) Get(bool withId)
    {
        ConsoleWrapper.WriteLine("Choose machine field:");
        string idOption = withId ? "id | " : string.Empty;
        string isReadyOption = withId ? " | isReady" : string.Empty;
        ConsoleWrapper.WriteLine($"{idOption}brand | model | year | price{isReadyOption}");
        
        var s = ConsoleWrapper.ReadLine();
        if (s is null) return (false, MachineField.Brand);
        
        (bool state, var field) = (false, MachineField.Brand);
        (state, field) = s switch
        {
            "id" => withId ? (true, MachineField.MachineId) : (state, field),
            "brand" => (true, MachineField.Brand),
            "model" => (true, MachineField.Model),
            "year" => (true, MachineField.Year),
            "price" => (true, MachineField.Price),
            "isReady" => withId ? (true, MachineField.IsReady) : (state, field),
            _ => (state, field)
        };

        return (state, field);
    }
}