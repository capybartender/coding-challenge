using Enpal.CodingChallenge.Core.Calendar;
using Enpal.CodingChallenge.Core.Calendar.Models;
using Enpal.CodingChallenge.Infrastructure.Mappings;
using Enpal.CodingChallenge.Infrastructure.Models;
using Enpal.CodingChallenge.Infrastructure.Repositories;

namespace Enpal.CodingChallenge.Infrastructure.Services;

public sealed class CalendarService : ICalendarService
{
    private readonly ISlotRepository _slotRepository;

    public CalendarService(ISlotRepository slotRepository)
    {
        _slotRepository = slotRepository;
    }
    
    public async Task<Slot[]> GetAvailableSlots(
        DateOnly date,
        IEnumerable<string> products,
        string language,
        string rating,
        CancellationToken ct)
    {
        var data = await _slotRepository.GetAvailableSlotsAsync(date, products, language, rating, ct);
        var result = data.ToCoreModels();
        return await Task.FromResult(result);
    }
}