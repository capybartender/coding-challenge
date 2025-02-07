using Enpal.CodingChallenge.Contracts.Requests;

namespace Enpal.CodingChallenge.Contracts.Tests.Requests;

public class GetAvailableAppointmentSlotsRequestValidatorTests
{
    private readonly GetAvailableAppointmentSlotsRequestValidator _validator = new();

    [Fact]
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
        Assert.True(result.IsValid);
    }

    [Fact]
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
        Assert.False(result.IsValid);
        Assert.Equal(3, result.Errors.Count);
    }
}
