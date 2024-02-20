namespace Lib.CustomEventArgs;

public class UpdateEventArgs : EventArgs
{
    public DateTime UpdateDT { get; set; }
    
    public UpdateEventArgs(DateTime dt) => UpdateDT = dt;
}