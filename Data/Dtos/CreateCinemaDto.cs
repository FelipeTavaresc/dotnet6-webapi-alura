using System.ComponentModel.DataAnnotations;

namespace MovieApi.Models;

public class CreateCinemaDto
{
    [Required(ErrorMessage = "The field Name is required.")]
    public string Name { get; set; }
    public int AddressId { get; set; }
}