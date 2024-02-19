using Core.Enums.EntityEnums;
using UI;

namespace Application.Handlers.CollectionBasedHandlers;

public static class RepairFieldHandler
{
    public static (bool, RepairField) Get()
    {
        ConsoleWrapper.WriteLine("Choose repair field:");
        ConsoleWrapper.WriteLine("id | issue | cost | technitian | isFixed | repairDate");
        
        // TODO: ЕСЛИ ЭТО EDIT ТО ID НАДО УБРАТЬ
        
        var s = ConsoleWrapper.ReadLine();
        if (s is null) throw new ArgumentNullException();
        
        (bool state, var field) = (false, RepairField.RepairId);
        (state, field) = s switch
        {
            "id" => (true, RepairField.RepairId),
            "issue" => (true, RepairField.Issue),
            "cost" => (true, RepairField.RepairCost),
            "technitian" => (true, RepairField.Technician),
            "isFixed" => (true, RepairField.IsFixed),
            "repairDate" => (true, RepairField.RepairDate),
            _ => (state, field)
        };

        return (state, field);
    }
}