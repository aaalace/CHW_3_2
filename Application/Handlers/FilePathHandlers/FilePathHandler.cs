using UI;

namespace Application.Handlers.FilePathHandlers;

public static class FilePathHandler
{
    /// <summary>
    /// Gets new path where to save data after formatting. 
    /// </summary>
    /// <returns>New path.</returns>
    public static (bool, string) Get()
    {
        ConsoleWrapper.WriteLine("Entry file path:");
        
        string? path = ConsoleWrapper.ReadLine();
        return path is null ? (false, string.Empty) : (File.Exists(path), path);
    }
}