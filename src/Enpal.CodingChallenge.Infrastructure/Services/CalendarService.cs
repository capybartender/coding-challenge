using Enpal.CodingChallenge.Core.Calendar;

namespace Enpal.CodingChallenge.Infrastructure.Services;

public class CalendarService : ICalendarService
{
    public async Task<string> GetData()
    {
        return await Task.FromResult("hello from service");
    }
}