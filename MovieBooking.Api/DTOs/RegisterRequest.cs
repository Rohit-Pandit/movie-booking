using System.ComponentModel.DataAnnotations;

namespace MovieBooking.Api.DTOs;

public class RegisterRequest
{
    [Required]
    public required string FullName { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    public required string Email { get; set; } = string.Empty;

    [Required]
    [MinLength(6)]
    public required string Password { get; set; } = string.Empty;
}

