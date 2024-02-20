using UI;

namespace Application.Handlers.CollectionBasedHandlers.TypeHandlers;

public static class DoubleHandler
{
    public static (bool, double) Get(string field)
    {
        ConsoleWrapper.WriteLine($"Entry {field} <double>:");
        
        string? s = ConsoleWrapper.ReadLine();
        if (s is null) throw new ArgumentNullException();

        return (double.TryParse(s, out double dbl), dbl);
    }
}