using Lib.CustomEventArgs;
using Lib.Data;
using UI;

namespace Lib.Entities;

public class AutoSaver
{
    private DateTime lastUpdate = DateTime.MinValue;
    
    public void OnUpdatedHandler(object? sender, UpdateEventArgs args)
    {
        if (lastUpdate == DateTime.MinValue)
        {
            lastUpdate = args.UpdateDT;
            return;
        }
        
        if (CheckTimeState(args.UpdateDT))
        {
            string tmpPath = $"{Storage.filePath.Value}_tmp.json";
            string json = JsonWorker.Converters.Serializer.Serialize(Storage.machineCollection.Value);
        
            JsonWorker.SourceInteractors.Writer.Write(tmpPath, json);
            
            ConsoleWrapper.WriteLine($"Data saved to {tmpPath}", ConsoleColor.DarkCyan);
        }

        lastUpdate = args.UpdateDT;
    }

    private bool CheckTimeState(DateTime newUpdate)
        => newUpdate.Subtract(lastUpdate) is { Days: 0, Hours: 0, Minutes: 0, Seconds: <= 30 };
}