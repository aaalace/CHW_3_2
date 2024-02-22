namespace Lib.CustomEventArgs;

/// <summary>
/// Event args for UpdateEventHandler.
/// </summary>
public class UpdateEventArgs : EventArgs
{
    public DateTime UpdateDT { get; set; }
    
    public UpdateEventArgs(DateTime dt) => UpdateDT = dt;
}