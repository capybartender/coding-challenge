using Enpal.CodingChallenge.Api.Mappings;
using Enpal.CodingChallenge.Contracts.Requests;
using Enpal.CodingChallenge.Contracts.ViewModels;
using Enpal.CodingChallenge.Core.Calendar.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Enpal.CodingChallenge.Api.Controllers;

[ApiController]
[Route("[controller]")]
public sealed class CalendarController : ControllerBase
{
    private readonly IMediator _mediator;

    public CalendarController(IMediator mediator) : base()
    {
        _mediator = mediator;
    }
    
    [HttpPost("query")]
    public async Task<ActionResult<IEnumerable<SlotViewModel>>> Query(
        [FromBody] GetAvailableAppointmentSlotsRequest request, 
        CancellationToken ct)
    {
        var query = new GetAvailableAppointmentSlotsQuery(
            request.Date,
            request.Products,
            request.Language,
            request.Rating);
        var slots = await _mediator.Send(query, ct);
        var result = slots.ToViewModels();
        return Ok(result);
    }
}