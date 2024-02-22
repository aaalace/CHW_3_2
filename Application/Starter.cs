using Application.Handlers.CommonHandlers;
using Core.Messages;
using UI;

namespace Application;

// Описание проекта в корневом каталоге - README.md

public static class Starter
{
    /// <summary>
    /// Program starter
    /// </summary>
    public static void Main()
    {
        ConsoleWrapper.WriteLine(Messages.start, ConsoleColor.DarkYellow);
        do
        {
            EntryPoint.Run();
        } while (ContinueRunApp());
    }
    
    private static bool ContinueRunApp()
    {
        ConsoleWrapper.WriteLine(Messages.endPoint);
        return ContinueRunAppHandler.Handle();
    }
}