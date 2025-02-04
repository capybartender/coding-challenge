using Enpal.CodingChallenge.Core.Calendar.Models;

namespace Enpal.CodingChallenge.Core.Calendar;

public interface ICalendarService
{
    Task<Slot[]> GetAvailableSlots(
        DateOnly date, 
        IEnumerable<string> products, 
        string language,
        string rating,
        CancellationToken ct);
}