using Enpal.CodingChallenge.Infrastructure.Repositories;
using Enpal.CodingChallenge.Infrastructure.Services;
using Enpal.CodingChallenge.Infrastructure.Tests.TestsSetup;

namespace Enpal.CodingChallenge.Infrastructure.Tests.Services;

public sealed class CalendarServiceTests : BaseTestcontainersTests
{
    [Fact]
    public async Task GetAvailableSlotsAsync_Should_ReturnThreeSlots()
    {
        // Arrange
        var repository = new SlotRepository(Postgres.GetConnectionString());
        var calendarService = new CalendarService(repository);

        // Act
        var slots = await calendarService.GetAvailableSlotsAsync(
            date: DateOnly.FromDateTime(new DateTime(2024, 5, 3)),
            products: ["SolarPanels", "Heatpumps"],
            language: "German",
            rating: "Gold",
            CancellationToken.None
        );

        // Assert
        Assert.Equal(3, slots.Length);
    }
}