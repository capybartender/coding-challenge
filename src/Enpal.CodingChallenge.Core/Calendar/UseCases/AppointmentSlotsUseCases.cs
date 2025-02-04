using Enpal.CodingChallenge.Core.Calendar.Models;
using Enpal.CodingChallenge.Core.Calendar.Queries;
using JetBrains.Annotations;
using MediatR;

namespace Enpal.CodingChallenge.Core.Calendar.UseCases;

[UsedImplicitly]
public class AppointmentSlotsUseCases : IRequestHandler<GetAvailableAppointmentSlotsQuery, IEnumerable<Slot>>
{
    private readonly ICalendarService _calendarService;

    public AppointmentSlotsUseCases(ICalendarService calendarService)
    {
        _calendarService = calendarService;
    }
    
    public async Task<IEnumerable<Slot>> Handle(GetAvailableAppointmentSlotsQuery query, CancellationToken cancellationToken)
    {
        var slot1 = new Slot(2, DateTimeOffset.UtcNow);
        var slot2 = new Slot(3, DateTimeOffset.UtcNow.AddDays(2));
        var result = new List<Slot> { slot1, slot2 };
        return await Task.FromResult(result);
        //return await _calendarService.GetData();
    }
}