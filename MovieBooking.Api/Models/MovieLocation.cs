namespace MovieBooking.Api.Models;

public class MovieLocation
{
    public int Id { get; set; }
    public int MovieId { get; set; }
    public int LocationId { get; set; }

    public Movie Movie { get; set; } = null!;
    public Location Location { get; set; } = null!;
}