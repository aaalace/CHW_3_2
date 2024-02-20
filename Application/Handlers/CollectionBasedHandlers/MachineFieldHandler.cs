using Core.Enums.EntityEnums;
using UI;

namespace Application.Handlers.CollectionBasedHandlers;

public static class MachineFieldHandler
{
    public static (bool, MachineField) Get(bool withId)
    {
        ConsoleWrapper.WriteLine("Choose machine field:");
        string idOption = withId ? "id | " : string.Empty;
        ConsoleWrapper.WriteLine($"{idOption}brand | model | year | price | isReady");
        
        var s = ConsoleWrapper.ReadLine();
        if (s is null) throw new ArgumentNullException();
        
        (bool state, var field) = (false, MachineField.Brand);
        (state, field) = s switch
        {
            "id" => withId ? (true, MachineField.MachineId) : (state, field),
            "brand" => (true, MachineField.Brand),
            "model" => (true, MachineField.Model),
            "year" => (true, MachineField.Year),
            "price" => (true, MachineField.Price),
            "isReady" => (true, MachineField.IsReady),
            _ => (state, field)
        };

        return (state, field);
    }
}