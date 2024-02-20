using Core.Messages;

namespace Core.Exceptions;

public class WrongRepairId : Exception
{
    public WrongRepairId() : base(ErrorMessages.wrongRepairId) {}
}