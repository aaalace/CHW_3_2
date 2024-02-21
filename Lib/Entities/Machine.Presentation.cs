using Lib.JsonWorker.Converters;

namespace Lib.Entities;

public partial class Machine
{
    public string ToJson() => Serializer.Serialize(this);
}