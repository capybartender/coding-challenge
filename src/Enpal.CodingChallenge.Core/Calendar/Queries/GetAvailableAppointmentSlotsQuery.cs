using Enpal.CodingChallenge.Core.Calendar.Models;
using MediatR;

namespace Enpal.CodingChallenge.Core.Calendar.Queries;

public record GetAvailableAppointmentSlotsQuery(
    DateOnly Date,
    IEnumerable<string> Products,
    string Language,
    string Rating)
    : IRequest<IEnumerable<Slot>>;