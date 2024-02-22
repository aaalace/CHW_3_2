using Lib.Data;
using UI;

namespace Application.Handlers.CommonHandlers;

public static class ShowHandler
{
    public static (bool, List<int>) Handle()
    {
        var currentMachineIdCollection = 
            Storage.machineCollection.Value.Select(x => x.MachineId).ToList();
        
        ConsoleWrapper.WriteLine("Enter machine's id:");
        ConsoleWrapper.Write("Avaliable ids: ");
        ConsoleWrapper.Write(string.Join(" | ", currentMachineIdCollection) + "\n", ConsoleColor.DarkCyan);
        ConsoleWrapper.Write("Avaliable format (with spaces after commas): ");
        ConsoleWrapper.Write("1, 2, 5\n", ConsoleColor.DarkCyan);
        ConsoleWrapper.Write("or (only one interval): ");
        ConsoleWrapper.Write("5-11\n", ConsoleColor.DarkCyan);
        
        var ids = new List<int>();
        
        var s = ConsoleWrapper.ReadLine();
        if (s is null) return (false, ids);

        foreach (var id in s.Split(", "))
        {
            if (int.TryParse(id, out int intId)) ids.Add(intId);
        }
        
        if (ids.Count == s.Split(',').Length) return (true, ids);
        
        ids.Clear();

        string[] borders = s.Split('-');
        if (borders.Length != 2) return (false, ids);
        if (!int.TryParse(borders[0], out int left) || !int.TryParse(borders[1], out int right)) return (false, ids);
        
        for (int i = left; i <= right; i++) ids.Add(i);
        
        var thrown = ids.Except(currentMachineIdCollection).ToList();

        if (thrown.Count != 0)
        {
            ConsoleWrapper.WriteLine("Unfortunatelly these ids do not exist:");
            ConsoleWrapper.WriteLine(string.Join(", ", thrown), ConsoleColor.DarkCyan);
        }
        
        var result = currentMachineIdCollection.Intersect(ids).ToList();

        if (result.Count != 0)
        {
            ConsoleWrapper.WriteLine("Here is machines with avaliable ids:");
            ConsoleWrapper.WriteLine(string.Join(", ", result), ConsoleColor.DarkCyan);
        }
        
        return (true, result);
    }
}