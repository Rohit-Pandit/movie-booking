using System.ComponentModel.DataAnnotations;

namespace MovieBooking.Api.DTOs;

public class UpdatePreferenceRequest
{
    [Required]
    public required string PreferredLanguage { get; set; }
}