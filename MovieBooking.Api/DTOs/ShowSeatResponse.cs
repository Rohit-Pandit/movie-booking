namespace MovieBooking.Api.DTOs
{
    public class ShowSeatResponse
    {
        public int SeatId { get; set; }
        public string SeatNumber { get; set; }=null!;
        public bool IsBooked { get; set; }
    }
}