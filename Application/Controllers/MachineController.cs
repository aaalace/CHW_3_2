using Core.Enums;

namespace Application.Controllers;

public static class MachineController
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
                // _service.ReadService();
                break;
            case MenuCommand.SortCollection:
                // _service.FilterService();
                break;
            case MenuCommand.EditEntity:
                // _service.SortService();
                break;
            case MenuCommand.Exit:
            default:
                break;
        }
    }
}