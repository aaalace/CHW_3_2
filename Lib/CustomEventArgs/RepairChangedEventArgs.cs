using Lib.Entities;

namespace Lib.CustomEventArgs;

/// <summary>
/// Event args for RepairChangedEventHandler.
/// </summary>
public class RepairChangedEventArgs : EventArgs
{
    public Machine Machine { get; set; }
    
    public RepairChangedEventArgs(Machine machine) => Machine = machine;
}