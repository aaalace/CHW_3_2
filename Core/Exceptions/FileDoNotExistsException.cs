using Core.Messages;

namespace Core.Exceptions;

public class FileDoNotExistsException : Exception
{
    public FileDoNotExistsException() : base(ErrorMessages.wrongFilePath) {}
}