using Enpal.CodingChallenge.Infrastructure.Models;
using Enpal.CodingChallenge.Infrastructure.Repositories;
using Enpal.CodingChallenge.Infrastructure.Tests.TestDataGenerators;
using Enpal.CodingChallenge.Infrastructure.Tests.TestsSetup;

namespace Enpal.CodingChallenge.Infrastructure.Tests.Repositories;

public sealed class SlotRepositoryTests : IClassFixture<DatabaseFixture>
{
    private DatabaseFixture _fixture;

    public SlotRepositoryTests(DatabaseFixture fixture)
    {
        _fixture = fixture;
    }
    
    [Theory]
    [MemberData(nameof(TestParametersGenerator.GetArgsRequests), MemberType = typeof(TestParametersGenerator))]
    public async Task GetAvailableSlotsAsync_Should_Pass(InputParameters input, SlotDalModel[] expected)
    {
        // Arrange
        var sut = new SlotRepository(_fixture.Postgres.GetConnectionString());

        // Act
        var result = await sut.GetAvailableSlotsAsync(
            input.Date,
            input.Products,
            input.Language,
            input.Rating,
            CancellationToken.None);

        // Assert
        Assert.Equal(expected.Length, result.Length);
        Assert.Equal(expected, result);
    }
}

