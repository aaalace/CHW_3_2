using System.Text.Json;
using Lib.Entities;

namespace Lib.JsonWorker.Converters;

public static class Serializer
{
    private static readonly JsonSerializerOptions jsonOptions = new() {WriteIndented = true};

    public static string Serialize(List<Machine> collection) 
        => JsonSerializer.Serialize(collection, jsonOptions);
    
    public static string Serialize(Machine machine) 
        => JsonSerializer.Serialize(machine, jsonOptions);
    
    public static string Serialize(Repair repair) 
        => JsonSerializer.Serialize(repair, jsonOptions);
}