using KinoX.Core.Models.Base;

namespace KinoX.Core.Models;

public class Hall : BaseEntity
{
    public string Name { get; set; }
    public int Capacity { get; set; }

    public List<Session> Sessions { get; set; }
}
