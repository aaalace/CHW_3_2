using Core.Enums.EntityEnums;
using UI;

namespace Application.Handlers.CollectionBasedHandlers;

public static class EntityToWorkWithHandler
{
    public static (bool, EntityToWorkWith) Get()
    {
        ConsoleWrapper.WriteLine("Choose entity to work with:");
        ConsoleWrapper.WriteLine("machine | repair");
        
        var s = ConsoleWrapper.ReadLine();
        if (s is null) throw new ArgumentNullException();
        
        (bool state, var entity) = (false, EntityToWorkWith.Machine);
        (state, entity) = s switch
        {
            "machine" => (true, EntityToWorkWith.Machine),
            "repair" => (true, EntityToWorkWith.Repair),
            _ => (state, entity)
        };

        return (state, entity);
    }
}