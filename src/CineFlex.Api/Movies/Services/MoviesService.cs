using CineFlex.Api.Movies.Models.Entities;
using CineFlex.Api.Movies.Repositories;

namespace CineFlex.Api.Movies.Services;

public class MoviesService(ILogger<MoviesService> _logger, IMoviesRepository _moviesRepository) : IMoviesService
{
    public async Task<IEnumerable<Movie>?> GetMovies()
    {
        throw new NotImplementedException();
    }

}