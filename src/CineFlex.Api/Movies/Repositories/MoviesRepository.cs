using CineFlex.Api.Movies.Models.Entities;

namespace CineFlex.Api.Movies.Repositories;

public class MoviesRepository : IMoviesRepository
{
    public async Task<Movie> GetMovieById(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Movie>> GetMovies()
    {
        throw new NotImplementedException();
    }

    public async Task<Movie> GetMovieByName(string name)
    {
        throw new NotImplementedException();
    }
}