using Core.Exceptions;
using UI;

namespace Application.Handlers;

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
        if (path is null) throw new ArgumentNullException();

        return (File.Exists(path), path);
    }
}