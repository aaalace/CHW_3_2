using Lib.Entities;
using Lib.JsonWorker.Converters;
using Lib.JsonWorker.SourceInteractors;

namespace Lib.Data;

public partial class Storage
{
    
    /// <summary>
    /// Reseting all items in Storage.
    /// </summary>
    public static void Reset()
    {
        filePath.UpdatePath(string.Empty);
        machineCollection.UpdateCollection(new List<Machine>());
    }
    
    /// <summary>
    /// Init file path update.
    /// </summary>
    /// <param name="path">New path.</param>
    public static void UpdateFilePath(string path)
    {
        filePath.UpdatePath(path);
        UpdateMachineCollection();
    }
    
    /// <summary>
    /// Init update of collection of machines.
    /// </summary>
    private static void UpdateMachineCollection()
    {
        var json = Reader.Read(filePath.Value);
        var collection = Deserializer.Deserialize(json);

        var autoSaver = new AutoSaver();
        var repairManager = new RepairManager();

        foreach (var machine in collection)
        {
            machine.Updated += autoSaver.OnUpdatedHandler;
            machine.RepairChanged += repairManager.OnRepairChangedHandler;
        }
        
        machineCollection.UpdateCollection(collection);
    }
}