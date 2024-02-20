namespace Lib.JsonWorker.SourceInteractors;

public static class Writer
{
    public static void Write(string path, string json) 
        => File.WriteAllText(path, json);
}