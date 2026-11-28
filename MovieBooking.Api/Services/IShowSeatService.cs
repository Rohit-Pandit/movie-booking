using MovieBooking.Api.DTOs;
namespace MovieBooking.Api.Services
{
    public interface IShowSeatService
    {
        Task<List<ShowSeatResponse>> GetShowSeatsAsync(int showId);
    }
}