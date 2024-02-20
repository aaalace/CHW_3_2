using Core.Enums;
using UI;

namespace Application.Handlers.CollectionBasedHandlers.EditEntityHandlers;

public static class EditFieldOrAddRepairHandler
{
    public static (bool, EditFieldOrAddRepair) Get()
    {
        ConsoleWrapper.WriteLine("Choose what you want to do:");
        ConsoleWrapper.WriteLine("editField | addRepair");
        
        var s = ConsoleWrapper.ReadLine();
        if (s is null) throw new ArgumentNullException();
        
        (bool state, var option) = (false, EditFieldOrAddRepair.EditField);
        (state, option) = s switch
        {
            "editField" => (true, EditFieldOrAddRepair.EditField),
            "addRepair" => (true, EditFieldOrAddRepair.AddRepair),
            _ => (state, option)
        };

        return (state, option);
    }
}