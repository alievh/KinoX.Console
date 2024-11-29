using KinoX.Core.Models.Base;

namespace KinoX.Core.Models;

public class Reservation : BaseEntity
{
    public string CustomerName { get; set; }
    public int TicketsCount { get; set; }
    public int SessionId { get; set; }
    public Session Session { get; set; }
}
