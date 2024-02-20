using System.Text.Json;
using Lib.Entities;

namespace Lib.JsonWorker.Converters;

public static class Deserializer
{
    public static List<Machine> Deserialize(string json)
        => JsonSerializer.Deserialize<List<Machine>>(json) ?? new List<Machine>();
}