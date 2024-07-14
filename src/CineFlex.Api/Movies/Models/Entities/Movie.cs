namespace CineFlex.Api.Movies.Models.Entities;

public class Movie
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string ReleaseDate { get; set; }
    public short Rating { get; set; }
    public Genre Genre { get; set; }
}

public enum Genre
{
    Action,
    Comedy,
    Drama,
    Horror,
    SciFi
}