using Microsoft.AspNetCore.Mvc;
using MovieApi.Models;

namespace MovieApi.Controller;

[ApiController]
[Route("[controller]")]
public class MovieController : ControllerBase
{
    private static List<Movie> movies = new List<Movie>();
    private static int id = 0;

    [HttpPost]
    public void AddMovie([FromBody] Movie movie)
    {
        movie.Id = id++;
        movies.Add(movie);
        Console.WriteLine(movie.Title);
        Console.WriteLine(movie.Duration);
    }

    [HttpGet]
    public IEnumerable<Movie> GetMovies()
    {
        return movies;
    }

    [HttpGet("{id}")]
    public Movie? GetMovieById(int id)
    {
        return movies.FirstOrDefault(movie => movie.Id == id);
    }
}