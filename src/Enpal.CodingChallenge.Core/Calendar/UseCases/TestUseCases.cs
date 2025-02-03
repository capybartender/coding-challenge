using Enpal.CodingChallenge.Core.Calendar.Queries;
using JetBrains.Annotations;
using MediatR;

namespace Enpal.CodingChallenge.Core.Calendar.UseCases;

[UsedImplicitly]
public class TestUseCases : IRequestHandler<TestQuery, string>
{
    private readonly ICalendarService _calendarService;

    public TestUseCases(ICalendarService calendarService)
    {
        _calendarService = calendarService;
    }
    
    public async Task<string> Handle(TestQuery query, CancellationToken cancellationToken)
    {
        return await _calendarService.GetData();
    }
}