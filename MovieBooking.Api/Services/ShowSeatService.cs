using Microsoft.EntityFrameworkCore;
using MovieBooking.Api.Data;
using MovieBooking.Api.DTOs;

namespace MovieBooking.Api.Services
{
    public class ShowSeatService : IShowSeatService
    {
        private readonly ApplicationDbContext _context;

        public ShowSeatService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<ShowSeatResponse>> GetShowSeatsAsync(int showId)
        {
            var showSeats = await _context.ShowSeats
                .Where(ss => ss.ShowId == showId)
                .Select(ss => new ShowSeatResponse
                {
                    SeatId = ss.SeatId,
                    SeatNumber = ss.Seat.SeatNumber,
                    IsBooked = ss.IsBooked
                })
                .ToListAsync();

            return showSeats;
        }
    }
}