namespace MovieApi.Models;

public class ReadCinemaDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ReadCinemaDto ReadAddressDto { get; set; }
}   