
namespace MovieBooking.Api.Models;

public class Show
{
    public int Id { get; set; }

    public DateTime ShowStartTime { get; set; }

    public decimal TicketPrice { get; set; }

    public int MovieId { get; set; }

    public int LocationId { get; set; }

    public bool IsActive { get; set; } = true;

    public Movie Movie { get; set; } = null!;

    public Location Location { get; set; } = null!;

    public ICollection<ShowSeat> ShowSeats { get; set; } = new List<ShowSeat>();
}
