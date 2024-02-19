using Core.Messages;

namespace Core.Exceptions;

public class WrongMachineId : Exception
{
    public WrongMachineId() : base(ErrorMessages.wrongMachineId) {}
}