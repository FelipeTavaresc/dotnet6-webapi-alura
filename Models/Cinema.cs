using System.ComponentModel.DataAnnotations;

namespace MovieApi.Models;

public class Cinema
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage = "The field Name is required.")]
    public string Name { get; set; }
}