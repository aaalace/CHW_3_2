using UI;

namespace Application.Handlers.CommonHandlers;

public static class ContinueRunAppHandler
{
    /// <summary>
    /// Handles if user wants to leave program
    /// </summary>
    /// <returns>User's choice</returns>
    public static bool Handle() => ConsoleWrapper.GetKey() != ConsoleKey.Q;
}