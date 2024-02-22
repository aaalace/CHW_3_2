using Lib.Data.SubSections;

namespace Lib.Data;

/// <summary>
/// Container for all Lib data.
/// </summary>
public static partial class Storage
{
    public static readonly FilePath filePath = new();
    public static readonly MachineCollection machineCollection = new();
}