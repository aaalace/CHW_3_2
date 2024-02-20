using Application.Controllers;
using Application.Services;
using Core.Enums;
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
                var command = MenuService.Run();

                if (command == MenuCommand.Exit)
                {
                    Storage.Reset();
                    break;
                }
                
                BaseController.Run(command);
            }
        }
        catch (Exception e)
        {
            ConsoleWrapper.WriteException(e);
        }
    }
}