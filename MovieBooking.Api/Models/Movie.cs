namespace MovieBooking.Api.Models;

public class Movie
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public int DurationMinutes { get; set; }
    public required string Language { get; set; }
    public int ReleaseYear { get; set; }
}