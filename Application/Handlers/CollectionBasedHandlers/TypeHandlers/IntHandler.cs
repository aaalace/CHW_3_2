using UI;

namespace Application.Handlers.CollectionBasedHandlers.TypeHandlers;

public static class IntHandler
{
    public static (bool, int) Get(string field)
    {
        ConsoleWrapper.WriteLine($"Entry {field} <integer>:");
        
        string? s = ConsoleWrapper.ReadLine();
        return s is null ? (false, 0) : (int.TryParse(s, out int integer), integer);
    }
}