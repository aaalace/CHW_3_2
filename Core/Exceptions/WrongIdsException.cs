using Core.Messages;

namespace Core.Exceptions;

public class WrongIdsException : Exception
{
    public WrongIdsException() : base(ErrorMessages.wrongIds) {}
}