using Core.Enums.EntityEnums;
using UI;

namespace Application.Handlers.CollectionBasedHandlers;

public static class MachineFieldHandler
{
    public static (bool, MachineField) Get()
    {
        ConsoleWrapper.WriteLine("Choose machine field:");
        ConsoleWrapper.WriteLine("id | brand | model | year | price | isReady");
        
        // TODO: ЕСЛИ ЭТО EDIT ТО ID НАДО УБРАТЬ
        
        var s = ConsoleWrapper.ReadLine();
        if (s is null) throw new ArgumentNullException();
        
        (bool state, var field) = (false, MachineField.MachineId);
        (state, field) = s switch
        {
            "id" => (true, MachineField.MachineId),
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