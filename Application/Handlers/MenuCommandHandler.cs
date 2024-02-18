using Core.Enums;
using Core.Exceptions;
using UI;

namespace Application.Handlers;

public static class MenuCommandHandler
{
    /// <summary>
    /// Returns enum option of user's choice.
    /// </summary>
    public static MenuCommand Handle()
    {
        ConsoleWrapper.WriteLine("Choose menu option:");
        ConsoleWrapper.WriteLine("path | sort | edit | exit");
        
        var s = ConsoleWrapper.ReadLine();
        if (s is null) throw new ArgumentNullException();
        
        // Console.WriteLine(s);
        
        return s switch
        {
            "path" => MenuCommand.FilePath,
            "sort" => MenuCommand.SortCollection,
            "edit" => MenuCommand.EditEntity,
            "exit" => MenuCommand.Exit,
            _ => throw new WrongMenuCommandException()
        };
    }
}