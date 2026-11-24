namespace MovieBooking.Api.DTOs;

public class LoginResponse
{
    public required string Token { get; set; }
    public int UserId { get; set; }
    public required string FullName { get; set; }
    public required string Email { get; set; }
    public required string PreferredLanguage { get; set; }
}