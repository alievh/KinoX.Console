using KinoX.Core.Models;

namespace KinoX.Services.Interfaces;

public interface IMovieService
{
    void Create(Movie movie);
    Movie Get(int id);
    List<Movie> GetAll();
    void Update(int id, Movie movie);
    void Delete(int id);
}
