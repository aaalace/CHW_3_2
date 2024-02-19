using Core.Messages;

namespace Core.Exceptions;

public class WrongSortOrderException : Exception
{
    public WrongSortOrderException() : base(ErrorMessages.wrongSortOrder) {}
}