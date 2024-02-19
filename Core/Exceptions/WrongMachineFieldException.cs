using Core.Messages;

namespace Core.Exceptions;

public class WrongMachineFieldException : Exception
{
    public WrongMachineFieldException() : base(ErrorMessages.wrongMachineField) {}
}