using Application.Handlers.CommonHandlers;
using Core.Exceptions;
using Lib.Data;
using UI;

namespace Application.Services;

public static class ShowService
{
    public static void Run()
    {
        (bool state, var ids) = (false, new List<int>());
        while (!state)
        {
            (state, ids) = ShowHandler.Handle();
            if (!state) ConsoleWrapper.WriteException(new WrongIdsException());
        }

        var machinesToShow =
            Storage.machineCollection.Value.Where(x => ids.Contains(x.MachineId)).ToList();

        string sep = "------------------------------------";
        for (int i = 0; i < machinesToShow.Count; i++)
        {
            var machine = machinesToShow[i];
            
            ConsoleWrapper.WriteLine(sep, ConsoleColor.DarkBlue);
            ConsoleWrapper.WriteLine(machine.ToJson());
            if (i == machinesToShow.Count - 1) ConsoleWrapper.WriteLine(sep, ConsoleColor.DarkBlue);
        }
    }
}