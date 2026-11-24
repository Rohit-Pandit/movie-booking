using MovieBooking.Api.Models;

namespace MovieBooking.Api.Services
{
    public interface ITokenService
    {
        string GenerateToken(User user);
    }
}