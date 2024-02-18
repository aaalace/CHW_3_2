using Core.Messages;

namespace Core.Exceptions;

public class WrongMenuCommandException : Exception
{
    public WrongMenuCommandException() : base(ErrorMessages.wrongMenuCommand) {}
}