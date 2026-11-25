namespace MovieBooking.Api.Models;

public class Location
{
    public int Id { get; set; }
    public required string City { get; set; }
    public required string State { get; set; }
 
    public bool IsActive  { get; set; } = true;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public ICollection<MovieLocation> MovieLocations { get; set; } = new List<MovieLocation>();
}