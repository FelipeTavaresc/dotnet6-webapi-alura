using System.ComponentModel.DataAnnotations;

namespace MovieApi.Data.Dtos;

public class ReadMovieDto
{
    public string Title { get; set; }
    public string Genre { get; set; }
    public int Duration { get; set; }
    public DateTime DateTimeRequest { get; set; } =  DateTime.Now;
}