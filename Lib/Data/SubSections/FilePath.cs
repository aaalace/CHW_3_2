namespace Lib.Data.SubSections;

public class FilePath
{
    public string Value { get; private set; } = string.Empty;

    public void UpdatePath(string newPath) => Value = newPath;
}