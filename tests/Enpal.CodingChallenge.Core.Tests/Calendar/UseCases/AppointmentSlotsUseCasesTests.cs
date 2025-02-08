using Enpal.CodingChallenge.Contracts;
using Enpal.CodingChallenge.Core.Calendar;
using Enpal.CodingChallenge.Core.Calendar.Queries;
using Enpal.CodingChallenge.Core.Calendar.UseCases;
using NSubstitute;

namespace Enpal.CodingChallenge.Core.Tests.Calendar.UseCases;

public sealed class AppointmentSlotsUseCasesTests
{
    private readonly ICalendarService _calendarService = Substitute.For<ICalendarService>();

    [Fact]
    public async Task GetAvailableSlotsAsync_Should_BeCalled()
    {
        // Arrange
        AppointmentSlotsUseCases sut = new (_calendarService);
        var query = new GetAvailableAppointmentSlotsQuery(
            DateOnly.FromDateTime(DateTime.UtcNow),
            Constants.Products,
            Constants.Languages.First(),
            Constants.Ratings.First());

        // Act
        await sut.Handle(query, CancellationToken.None);

        //Assert
        Received.InOrder(async () =>
        {
            await _calendarService.GetAvailableSlotsAsync(query.Date, query.Products, query.Language, query.Rating, CancellationToken.None);
        });
    }
}
