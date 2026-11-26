using MovieBooking.Api.Models;

public class Seat
{
    public int Id { get; set; }
    public string SeatNumber { get; set; } = null!;
    public bool IsActive { get; set; } = true;

    public ICollection<ShowSeat> ShowSeats { get; set; } = new List<ShowSeat>();
}