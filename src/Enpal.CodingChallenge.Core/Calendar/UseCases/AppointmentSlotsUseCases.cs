using Enpal.CodingChallenge.Core.Calendar.Models;
using Enpal.CodingChallenge.Core.Calendar.Queries;
using JetBrains.Annotations;
using MediatR;

namespace Enpal.CodingChallenge.Core.Calendar.UseCases;

[UsedImplicitly]
public sealed class AppointmentSlotsUseCases : IRequestHandler<GetAvailableAppointmentSlotsQuery, Slot[]>
{
    private readonly ICalendarService _calendarService;

    public AppointmentSlotsUseCases(ICalendarService calendarService)
        => _calendarService = calendarService;

    public async Task<Slot[]> Handle(GetAvailableAppointmentSlotsQuery query, CancellationToken ct)
    {
        return await _calendarService.GetAvailableSlotsAsync(
            query.Date,
            query.Products,
            query.Language,
            query.Rating,
            ct);
    }
}