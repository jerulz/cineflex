using CineFlex.Api.Movies.Models.Entities;
using CineFlex.Api.Movies.Services;
using Microsoft.AspNetCore.Mvc;

namespace CineFlex.Api.Movies.Controllers;

[Microsoft.AspNetCore.Components.Route("api/movies/[controller]")]
[ApiController]
public class MoviesController(ILogger<MoviesController> _logger, MoviesService _moviesService) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Movie>>> GetMovies()
    {
        try
        {
            IEnumerable<Movie>? movies = await _moviesService.GetMovies();
            return Ok(movies);
        }
        catch (Exception e)
        {
            string message = $"An error occurred while getting movies: {e.Message}";
            _logger.LogError(message);
            return Problem(message);
        }
        
    }
}