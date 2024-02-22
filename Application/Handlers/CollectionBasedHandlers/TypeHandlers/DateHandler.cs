using UI;

namespace Application.Handlers.CollectionBasedHandlers.TypeHandlers;

public static class DateHandler
{
    public static (bool, DateTime) Get(string field)
    {
        ConsoleWrapper.WriteLine($"Entry {field} <DateTime> (dd/mm/yyyy):");
        
        string? s = ConsoleWrapper.ReadLine();
        if (s is null) return (false, DateTime.MinValue);

        return (DateTime.TryParse(s, out var dt), dt);
    }
}