namespace Lib.Data.SubSections;

/// <summary>
/// Container of path.
/// </summary>
public class FilePath
{
    public string Value { get; private set; } = string.Empty;

    public void UpdatePath(string newPath) => Value = newPath;
}