using CineFlex.Api.Movies.Models.Entities;

namespace CineFlex.Api.Movies.Services;

public interface IMoviesService
{
    Task<IEnumerable<Movie>?> GetMovies();
}