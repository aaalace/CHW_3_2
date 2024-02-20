using Application.Handlers.CommonHandlers;
using Core.Enums;
using Core.Exceptions;
using UI;

namespace Application.Services;

public static class MenuService
{
    public static MenuCommand Run()
    {
        (bool menuState, var command) = (false, MenuCommand.FilePath);
        while (!menuState)
        {
            (menuState, command) = MenuCommandHandler.Handle();
            if (!menuState) ConsoleWrapper.WriteException(new WrongMenuCommandException());
        }
        
        return command;
    }
}