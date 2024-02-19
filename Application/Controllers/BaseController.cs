using Application.Services;
using Core.Enums;

namespace Application.Controllers;

public static class BaseController
{
    /// <summary>
    /// Runs a task from menu.
    /// </summary>
    /// <param name="command">Command chosen by user.</param>
    public static void Run(MenuCommand command)
    {
        switch (command)
        {
            case MenuCommand.FilePath:
                FilePathService.Run();
                break;
            case MenuCommand.SortCollection:
                SortCollectionService.Run();
                break;
            case MenuCommand.EditEntity:
                EditEntityService.Run();
                break;
            case MenuCommand.Exit:
            default:
                break;
        }
    }
}