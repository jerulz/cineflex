using CineFlex.Api.Movies.Models.Entities;

namespace CineFlex.Api.Movies.Models.Dtos;

public class MovieDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string ReleaseDate { get; set; }
    public short Rating { get; set; }
    public Genre Genre { get; set; }
}