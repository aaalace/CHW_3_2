using Core.Messages;

namespace Core.Exceptions;

public class WrongTypeException : Exception
{
    public WrongTypeException() : base(ErrorMessages.wrongTypeException) {}
}