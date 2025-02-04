using System.ComponentModel.DataAnnotations;

namespace Enpal.CodingChallenge.Contracts.Requests;

public record GetAvailableAppointmentSlotsRequest
{
    [Required] 
    public DateOnly Date { get; init; }
    
    [Required]
    public IEnumerable<string> Products { get; init; }
    
    [Required] 
    public string Language { get; init; }
    
    [Required]
    public string Rating { get; init; }
}