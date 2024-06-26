﻿using Lib.Data;
using UI;

namespace Application.Handlers.CollectionBasedHandlers;

public static class MachineIdHandler
{
    public static (bool, int) Get()
    {
        var currentMachineIdCollection = 
            Storage.machineCollection.Value.Select(x => x.MachineId).ToList();
        
        ConsoleWrapper.WriteLine("Choose machine id:");
        ConsoleWrapper.WriteLine(string.Join(" | ", currentMachineIdCollection), ConsoleColor.DarkCyan);

        var s = ConsoleWrapper.ReadLine();
        if (s is null) return (false, 0);

        return int.TryParse(s, out int id) && currentMachineIdCollection.Contains(id) ? (true, id) : (false, 0);
    }
}