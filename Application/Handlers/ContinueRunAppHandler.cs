using UI;

namespace Application.Handlers;

public static class ContinueRunAppHandler
{
    /// <summary>
    /// Checks if user wants to exit program.
    /// </summary>
    public static bool Handle() => ConsoleWrapper.GetKey() != ConsoleKey.Q;
}