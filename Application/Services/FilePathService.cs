using Core.Exceptions;
using Lib.Data;
using Application.Handlers.FilePathHandlers;
using UI;

namespace Application.Services;

public static class FilePathService
{
    /// <summary>
    /// Runs service for editing file path.
    /// </summary>
    public static void Run()
    {
        (bool state, string path) = (false, string.Empty);
        while (!state)
        {
            (state, path) = FilePathHandler.Get();
            if (!state) ConsoleWrapper.WriteException(new FileDoNotExistsException());
        }

        Storage.UpdateFilePath(path);
    }
}