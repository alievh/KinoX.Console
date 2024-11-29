using KinoX.Core.Enums;
using KinoX.Core.Models.Base;

namespace KinoX.Core.Models;

public class Movie : BaseEntity
{
    public string Title { get; set; }
    public int Duration { get; set; }
    public Genre Genre { get; set; }
    public List<Session> Sessions { get; set; }
}
