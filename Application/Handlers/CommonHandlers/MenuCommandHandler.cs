using Core.Enums;
using UI;

namespace Application.Handlers.CommonHandlers;

public static class MenuCommandHandler
{
    /// <summary>
    /// Returns enum option of user's choice.
    /// </summary>
    public static (bool, MenuCommand) Handle()
    {
        ConsoleWrapper.WriteLine("Choose menu option:");
        ConsoleWrapper.WriteLine("show | path | sort | edit | exit");
        
        var s = ConsoleWrapper.ReadLine();
        if (s is null) throw new ArgumentNullException();
        
        (bool state, var command) = (false, MenuCommand.FilePath);
        (state, command) = s switch
        {
            "show" => (true, MenuCommand.Show),
            "path" => (true, MenuCommand.FilePath),
            "sort" => (true, MenuCommand.SortCollection),
            "edit" => (true, MenuCommand.EditEntity),
            "exit" => (true, MenuCommand.Exit),
            _ => (state, command)
        };

        return (state, command);
    }
}