namespace UI;

public static class ConsoleWrapper
{
    public static void Write(string s, ConsoleColor color = ConsoleColor.White)
    {
        Console.ForegroundColor = color;
        Console.Write(s);
        Console.ResetColor();
    }
    
    public static void WriteLine(string line, ConsoleColor color = ConsoleColor.White)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(line);
        Console.ResetColor();
    }
    
    public static void WriteException(Exception exception)
    {
        WriteLine($"<ERROR> {exception.Message}", ConsoleColor.Red);
    }
    
    public static string? ReadLine()
    {
        Write("> ");
        return Console.ReadLine();
    }
    
    public static ConsoleKey GetKey() => Console.ReadKey(true).Key;
}