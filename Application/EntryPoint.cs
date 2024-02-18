using Application.Controllers;
using Application.Handlers;
using Core.Enums;
using Core.Exceptions;
using UI;

namespace Application;

public static class EntryPoint
{
    public static void Run()
    {
        try
        {
            (bool state, string filePath) = (false, string.Empty);
            while (!state)
            {
                (state, filePath) = FilePathHandler.Get();
                ConsoleWrapper.WriteException(new FileDoNotExistsException());
            }
            
            Console.WriteLine(filePath);
            // (Lib) FilePath.UpdateFilePath(filePath);

            while (true)
            {
                var command = MenuCommandHandler.Handle();
                // Console.WriteLine(command);
                if (command == MenuCommand.Exit) break;
                
                MachineController.Run(command);
            }
        }
        catch (Exception e)
        {
            ConsoleWrapper.WriteException(e);
        }
    }
}