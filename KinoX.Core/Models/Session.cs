using KinoX.Core.Models.Base;

namespace KinoX.Core.Models;

public class Session : BaseEntity
{
    public DateTime StartTime { get; set; }
    public double Price { get; set; }

    public int MovieId { get; set; }
    public Movie Movie { get; set; }
    public int HallId { get; set; }
    public Hall Hall { get; set; }

    public List<Reservation> Reservations { get; set; }
}
