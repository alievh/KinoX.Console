using KinoX.Core.Models;
using KinoX.Services.Implementations;

namespace KinoX.App
{
    internal class Program
    {

        static void Main(string[] args)
        {
            HallService hallService = new HallService();
            MovieService movieService = new MovieService();
            Movie movie = new Movie();
            movie.Title = "Ziyanin drami";
            movie.Genre = Core.Enums.Genre.Drama;
            movie.Duration = 120;
            movieService.Create(movie);
        }
    }
}
