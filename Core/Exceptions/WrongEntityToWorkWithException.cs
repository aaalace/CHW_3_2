using Core.Messages;

namespace Core.Exceptions;

public class WrongEntityToWorkWithException : Exception
{
    public WrongEntityToWorkWithException() : base(ErrorMessages.wrongEntityToWorkWith) {}
}