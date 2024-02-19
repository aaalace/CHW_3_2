using Lib.Data;
using UI;

namespace Application.Handlers.CollectionBasedHandlers;

public static class MachineIdHandler
{
    public static (bool, int) Get()
    {
        ConsoleWrapper.WriteLine("Enter machine id");

        var s = ConsoleWrapper.ReadLine();
        if (s is null) throw new ArgumentNullException();

        var currentMachineIdCollection = Storage.machineCollection.Value.Select(x => x.MachineId).ToList();

        return int.TryParse(s, out int id) && currentMachineIdCollection.Contains(id) ? (true, id) : (false, 1);
    }
}