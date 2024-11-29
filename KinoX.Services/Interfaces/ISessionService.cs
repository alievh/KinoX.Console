using KinoX.Core.Models;

namespace KinoX.Services.Interfaces
{
    public interface ISessionService
    {
        void Create(Session session);
        Session Get(int id);
        List<Session> GetAll();
        void Update(int id, Session session);
        void Delete(int id);
    }
}
