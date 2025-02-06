using Enpal.CodingChallenge.Contracts.Requests;

namespace Enpal.CodingChallenge.Contracts.Tests.Requests;

public class GetAvailableAppointmentSlotsRequestValidatorTests
{
    private readonly GetAvailableAppointmentSlotsRequestValidator _validator = new();

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ShouldPass()
    {
        // Arrange
        var validRequest = new GetAvailableAppointmentSlotsRequest 
        {
            Date = DateOnly.FromDateTime(DateTime.UtcNow),
            Language = Constants.Languages.First(),
            Products = Constants.Products, 
            Rating = Constants.Ratings.First()
        };

        // Act
        var result = _validator.Validate(validRequest);

        // Assert
        Assert.That(result.IsValid, Is.True);
    }

    [Test]
    public void ShouldFail()
    {
        // Arrange
        var invalidRequest = new GetAvailableAppointmentSlotsRequest
        {
            Date = DateOnly.FromDateTime(DateTime.UtcNow),
            Language = "Spanish",
            Products = [],
            Rating = "Platinum"
        };

        // Act
        var result = _validator.Validate(invalidRequest);

        // Assert
        Assert.That(result.IsValid, Is.False);
        Assert.That(result.Errors.Count, Is.EqualTo(3));
    }
}
