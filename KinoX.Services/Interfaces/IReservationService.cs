using KinoX.Core.Models;

namespace KinoX.Services.Interfaces;

public interface IReservationService
{
    void Create(Reservation reservation);
    Reservation Get(int id);
    List<Reservation> GetAll();
    void Update(int id, Reservation reservation);
    void Delete(int id);
}
