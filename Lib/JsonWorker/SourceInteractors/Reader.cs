namespace Lib.JsonWorker.SourceInteractors;

public static class Reader
{
    public static string Read(string path)
    {
        string json = File.ReadAllText(path);

        return json;
    }
}