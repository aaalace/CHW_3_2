using Lib.JsonWorker.Converters;

namespace Lib.Entities;

public partial class Repair
{
    public string ToJson() => Serializer.Serialize(this);
}