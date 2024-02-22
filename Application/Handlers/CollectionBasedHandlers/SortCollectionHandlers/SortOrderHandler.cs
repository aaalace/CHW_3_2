using Core.Enums;
using UI;

namespace Application.Handlers.CollectionBasedHandlers.SortCollectionHandlers;

public static class SortOrderHandler
{
    /// <summary>
    /// Returns sort order.
    /// </summary>
    public static (bool, SortOrder) Get()
    {
        ConsoleWrapper.WriteLine("Choose sort order:");
        ConsoleWrapper.WriteLine("increase | decrease");
        
        var s = ConsoleWrapper.ReadLine();
        if (s is null) return (false, SortOrder.Increase);
        
        (bool state, var order) = (false, SortOrder.Increase);
        (state, order) = s switch
        {
            "increase" => (true, SortOrder.Increase),
            "decrease" => (true, SortOrder.Decrease),
            _ => (state, order)
        };

        return (state, order);
    }
}