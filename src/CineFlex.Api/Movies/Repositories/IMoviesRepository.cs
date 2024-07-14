using CineFlex.Api.Movies.Models.Entities;

namespace CineFlex.Api.Movies.Repositories;

public interface IMoviesRepository
{
    Task<Movie> GetMovieById(int id);
    
    Task<IEnumerable<Movie>> GetMovies();
    
    Task<Movie> GetMovieByName(string name);
}