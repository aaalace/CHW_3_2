using Lib.Entities;

namespace Lib.Data.SubSections;

/// <summary>
/// Container of collection.
/// </summary>
public class MachineCollection
{
    public List<Machine> Value { get; private set; } = new();
    
    public void UpdateCollection(List<Machine> newCollection) => Value = newCollection;
}