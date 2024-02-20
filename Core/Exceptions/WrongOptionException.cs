using Core.Messages;

namespace Core.Exceptions;

public class WrongOptionException : Exception
{
    public WrongOptionException() : base(ErrorMessages.wrongOption) {}
}