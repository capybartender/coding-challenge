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

    public async Task<Slot[]> Handle(GetAvailableAppointmentSlotsQuery cmd, CancellationToken ct)
    {
        return await _calendarService.GetAvailableSlots(
            cmd.Date,
            cmd.Products,
            cmd.Language,
            cmd.Rating,
            ct);
    }
}