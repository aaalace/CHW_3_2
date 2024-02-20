using Core.Enums.EntityEnums;
using UI;

namespace Application.Handlers.CollectionBasedHandlers;

public static class RepairFieldHandler
{
    public static (bool, RepairField) Get(bool withId)
    {
        ConsoleWrapper.WriteLine("Choose repair field:");
        string idOption = withId ? "id | " : string.Empty;
        ConsoleWrapper.WriteLine($"{idOption}issue | cost | technician | isFixed | repairDate");
        
        var s = ConsoleWrapper.ReadLine();
        if (s is null) throw new ArgumentNullException();
        
        (bool state, var field) = (false, RepairField.Issue);
        (state, field) = s switch
        {
            "id" => withId ? (true, RepairField.RepairId) : (state, field),
            "issue" => (true, RepairField.Issue),
            "cost" => (true, RepairField.RepairCost),
            "technician" => (true, RepairField.Technician),
            "isFixed" => (true, RepairField.IsFixed),
            "repairDate" => (true, RepairField.RepairDate),
            _ => (state, field)
        };

        return (state, field);
    }
}