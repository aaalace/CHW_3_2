using Application.Controllers;
using Application.Handlers.CommonHandlers;
using Application.Services;
using Core.Enums;
using Core.Exceptions;
using Lib.Data;
using UI;

namespace Application;

public static class EntryPoint
{
    public static void Run()
    {
        try
        {
            FilePathService.Run();
            
            while (true)
            {
                (bool menuState, var command) = (false, MenuCommand.FilePath);
                while (!menuState)
                {
                    (menuState, command) = MenuCommandHandler.Handle();
                    if (!menuState) ConsoleWrapper.WriteException(new WrongMenuCommandException());
                }
                
                if (command == MenuCommand.Exit)
                {
                    Storage.Reset();
                    break;
                }
                
                BaseController.Run(command);

                Console.WriteLine(Storage.machineCollection);
            }
        }
        catch (Exception e)
        {
            ConsoleWrapper.WriteException(e);
        }
    }
}