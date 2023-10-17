using System.ComponentModel.DataAnnotations;

namespace MovieApi.Data.Dtos;

public class UpdateCinemaDto
{
    [Required(ErrorMessage = "The field Name is required.")]
    public string Name { get; set; }
}