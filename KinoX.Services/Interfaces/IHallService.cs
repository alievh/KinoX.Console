using KinoX.Core.Models;

namespace KinoX.Services.Interfaces;

public interface IHallService
{
    void Create(Hall movie);
    Hall Get(int id);
    List<Hall> GetAll();
    void Update(int id, Hall hall);
    void Delete(int id);
}
