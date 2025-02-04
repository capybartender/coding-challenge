using Enpal.CodingChallenge.Core.Calendar;
using Enpal.CodingChallenge.Core.Calendar.Models;
using Enpal.CodingChallenge.Infrastructure.Mappings;
using Enpal.CodingChallenge.Infrastructure.Models;

namespace Enpal.CodingChallenge.Infrastructure.Services;

public sealed class CalendarService : ICalendarService
{
    public async Task<Slot[]> GetAvailableSlots(
        DateOnly date,
        IEnumerable<string> products,
        string language,
        string rating,
        CancellationToken ct)
    {
        var slot1 = new SlotDal{AvailableCount = 2, StartDate = DateTimeOffset.UtcNow};
        var slot2 = new SlotDal{AvailableCount = 3, StartDate = DateTimeOffset.UtcNow.AddDays(2)};
        var data = new [] { slot1, slot2 };
        var result = data.ToCoreModels();
        return await Task.FromResult(result);
    }
}