using KinoX.Core.Models;
using KinoX.Data.DAL;
using KinoX.Services.Interfaces;

namespace KinoX.Services.Implementations;

public class MovieService : IMovieService
{
    private readonly KinoXDbContext _dbContext;

    public MovieService()
    {
        _dbContext = new KinoXDbContext();
    }

    public void Create(Movie movie)
    {
        movie.CreatedDate = DateTime.UtcNow.AddHours(4);
        _dbContext.Movies.Add(movie);
        _dbContext.SaveChanges();
    }

    public void Delete(int id)
    {
        Movie movie = Get(id);
        if (movie == null)
        {
            throw new NullReferenceException();
        }

        movie.IsDeleted = true;
        _dbContext.SaveChanges();
    }

    public Movie Get(int id)
    {
        Movie movie = _dbContext.Movies.FirstOrDefault(x => x.Id == id && !x.IsDeleted);
        if (movie == null)
        {
            throw new NullReferenceException();
        }

        return movie;
    }

    public List<Movie> GetAll()
    {
        List<Movie> movies = _dbContext.Movies.Where(n => !n.IsDeleted).ToList();
        if (movies == null)
        {
            throw new NullReferenceException();
        }
        return movies;
    }

    public void Update(int id, Movie movie)
    {
        Movie movieDb = Get(id);
        if (movieDb == null)
        {
            throw new NullReferenceException();
        }
        movieDb.Title = movie.Title;
        movieDb.UpdateDate = DateTime.UtcNow.AddHours(4);
        movieDb.Duration = movie.Duration;
        movieDb.Genre = movie.Genre;
        _dbContext.SaveChanges();
    }
}
