namespace Lib.JsonWorker.SourceInteractors;

public static class Reader
{
    public static string Read(string path) => File.ReadAllText(path);
}