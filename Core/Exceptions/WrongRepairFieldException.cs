using Core.Messages;

namespace Core.Exceptions;

public class WrongRepairFieldException : Exception
{
    public WrongRepairFieldException() : base(ErrorMessages.wrongRepairField) {}
}