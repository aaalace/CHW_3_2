using UI;

namespace Application.Handlers.CollectionBasedHandlers.TypeHandlers;

public static class StringHandler
{
    public static (bool, string) Get(string field)
    {
        ConsoleWrapper.WriteLine($"Entry {field} <string>:");
        
        string? s = ConsoleWrapper.ReadLine();
        if (s is null) throw new ArgumentNullException();

        return (true, s);
    }
}