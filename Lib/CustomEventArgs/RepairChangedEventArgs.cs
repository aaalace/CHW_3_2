using Lib.Entities;

namespace Lib.CustomEventArgs;

public class RepairChangedEventArgs : EventArgs
{
    public Machine Machine { get; set; }
    
    public RepairChangedEventArgs(Machine machine) => Machine = machine;
}