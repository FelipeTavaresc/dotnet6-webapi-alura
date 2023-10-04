using System.ComponentModel.DataAnnotations;

namespace MovieApi.Data.Dtos;

public class UpdateMovieDto
{
    [Required(ErrorMessage = "The movie title is required")]
    public string Title { get; set; }
    [Required(ErrorMessage = "The movie genre is required")]
    [StringLength(50, ErrorMessage = "The maxlength for genre field is 50 characters")]
    public string Genre { get; set; }
    [Required]
    [Range(70, 600, ErrorMessage = "The duration must be between 70 and 600 minutes")]
    public int Duration { get; set; }
}