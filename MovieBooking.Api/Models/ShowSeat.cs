using MovieBooking.Api.Models;

public class ShowSeat
{
    public int Id { get; set; }

    public int ShowId { get; set; }

    public int SeatId { get; set; }

    public bool IsBooked { get; set; } = false;

    public Show Show { get; set; } = null!;

    public Seat Seat { get; set; } = null!;
}