using UI;

namespace Application.Handlers.CollectionBasedHandlers.TypeHandlers;

public static class BoolHandler
{
    public static (bool, bool) Get(string field)
    {
        ConsoleWrapper.WriteLine($"Entry {field} <boolean>:");
        
        string? s = ConsoleWrapper.ReadLine();
        if (s is null) return (false, false);

        return (bool.TryParse(s, out bool boolean), boolean);
    }
}