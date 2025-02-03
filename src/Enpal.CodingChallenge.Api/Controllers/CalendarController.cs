using Enpal.CodingChallenge.Core.Calendar.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Enpal.CodingChallenge.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class CalendarController : ControllerBase
{
    private readonly IMediator _mediator;

    public CalendarController(IMediator mediator) : base()
    {
        _mediator = mediator;
    }
    
    [HttpPost("query")]
    public async Task<IActionResult> Query()
    {
        var query = new TestQuery();
        var result = await _mediator.Send(query);
        return Ok(result);
    }
}