using System.Text.Json;
using Machine = Lib.Entities.Machine;

namespace Lib.JsonWorker.Converters;

public static class Serializer
{
    public static string Serialize(List<Machine> collection) 
        => JsonSerializer.Serialize(collection);
}