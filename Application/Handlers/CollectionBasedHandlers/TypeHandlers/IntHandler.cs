using UI;

namespace Application.Handlers.CollectionBasedHandlers.TypeHandlers;

public static class IntHandler
{
    public static (bool, int) Get(string field)
    {
        ConsoleWrapper.WriteLine($"Entry {field} <integer>:");
        
        string? s = ConsoleWrapper.ReadLine();
        if (s is null) throw new ArgumentNullException();

        return (int.TryParse(s, out int integer), integer);
    }
}