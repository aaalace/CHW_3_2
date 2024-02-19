using System.Text.Json;
using Lib.Entities;

namespace Lib.JsonWorker.Converters;

public static class Deserializer
{
    public static List<Machine> Deserialize(string json)
    {
        var machines = JsonSerializer.Deserialize<List<Machine>>(json);

        return machines ?? new List<Machine>();
    }
}