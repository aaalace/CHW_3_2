using Lib.Entities;

namespace Lib.Data.SubSections;

public class MachineCollection
{
    public List<Machine> Value { get; private set; } = new();
    
    public void UpdateCollection(List<Machine> newCollection) => Value = newCollection;
}