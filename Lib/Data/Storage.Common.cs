using Lib.Entities;
using Lib.JsonWorker.Converters;
using Lib.JsonWorker.SourceInteractors;

namespace Lib.Data;

public partial class Storage
{
    public static void Reset()
    {
        filePath.UpdatePath(string.Empty);
        machineCollection.UpdateCollection(new List<Machine>());
    }
    
    public static void UpdateFilePath(string path)
    {
        filePath.UpdatePath(path);
        UpdateMachineCollection();
    }
    
    private static void UpdateMachineCollection()
    {
        var json = Reader.Read(filePath.Value);
        var collection = Deserializer.Deserialize(json);

        var autoSaver = new AutoSaver();

        foreach (var machine in collection) machine.Updated += autoSaver.OnUpdatedHandler;
        
        machineCollection.UpdateCollection(collection);
    }
}