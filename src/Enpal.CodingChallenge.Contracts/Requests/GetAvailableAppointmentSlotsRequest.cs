using System.ComponentModel.DataAnnotations;

namespace Enpal.CodingChallenge.Contracts.Requests;

public sealed record GetAvailableAppointmentSlotsRequest
{
    [Required] 
    public required DateOnly Date { get; init; }
    
    [Required]
    public required IEnumerable<string> Products { get; init; }
    
    [Required] 
    public required string Language { get; init; }
    
    [Required]
    public required string Rating { get; init; }
}