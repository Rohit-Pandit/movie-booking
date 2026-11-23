using System.ComponentModel.DataAnnotations;

namespace MovieBooking.Api.DTOs;
public class LoginRequest
{
    [Required]
    [EmailAddress]
    public required string Email { get; set; } = string.Empty;

    [Required]
    public required string Password { get; set; } = string.Empty;
}