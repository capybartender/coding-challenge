using Enpal.CodingChallenge.Infrastructure.Models;

namespace Enpal.CodingChallenge.Infrastructure.Tests.TestDataGenerators;

public sealed class TestParametersGenerator
{
    public static IEnumerable<object[]> GetArgsRequests()
    {
        yield return
        [
            new InputParameters(
                DateOnly.FromDateTime(new DateTime(2024, 5, 3)),
                ["SolarPanels", "Heatpumps"],
                "German",
                "Gold"),
            new SlotDalModel[]
            {
                new() { StartDate = DateTimeOffset.Parse("2024-05-03T10:30:00.000Z"), AvailableCount = 1 },
                new() { StartDate = DateTimeOffset.Parse("2024-05-03T11:00:00.000Z"), AvailableCount = 1 },
                new() { StartDate = DateTimeOffset.Parse("2024-05-03T11:30:00.000Z"), AvailableCount = 1 }
            }
        ];

        yield return
        [
            new InputParameters(
                DateOnly.FromDateTime(new DateTime(2024, 5, 3)),
                ["Heatpumps"],
                "English",
                "Silver"
            ),
            new SlotDalModel[]
            {
                new() { StartDate = DateTimeOffset.Parse("2024-05-03T10:30:00.000Z"), AvailableCount = 1 },
                new() { StartDate = DateTimeOffset.Parse("2024-05-03T11:00:00.000Z"), AvailableCount = 1 },
                new() { StartDate = DateTimeOffset.Parse("2024-05-03T11:30:00.000Z"), AvailableCount = 2 },
            }
        ];

        yield return
        [
            new InputParameters(
                DateOnly.FromDateTime(new DateTime(2024, 5, 3)),
                ["SolarPanels"],
                "German",
                "Bronze"),
            new SlotDalModel[]
            {
                new() { StartDate = DateTimeOffset.Parse("2024-05-03T10:30:00.000Z"), AvailableCount = 1 },
                new() { StartDate = DateTimeOffset.Parse("2024-05-03T11:00:00.000Z"), AvailableCount = 1 },
                new() { StartDate = DateTimeOffset.Parse("2024-05-03T11:30:00.000Z"), AvailableCount = 1 },
            }
        ];

        yield return
        [
            new InputParameters(
                DateOnly.FromDateTime(new DateTime(2024, 5, 4)),
                ["SolarPanels", "Heatpumps"],
                "German",
                "Gold"
            ),
            new SlotDalModel[] { }
        ];

        yield return
        [
            new InputParameters(
                DateOnly.FromDateTime(new DateTime(2024, 5, 4)),
                ["Heatpumps"],
                "English",
                "Silver"
            ),
            new SlotDalModel[]
            {
                new() { StartDate = DateTimeOffset.Parse("2024-05-04T11:30:00.000Z"), AvailableCount = 1 },
            }
        ];

        yield return
        [
            new InputParameters(
                DateOnly.FromDateTime(new DateTime(2024, 5, 4)),
                ["SolarPanels"],
                "German",
                "Bronze"
            ),
            new SlotDalModel[]
            {
                new() { StartDate = DateTimeOffset.Parse("2024-05-04T10:30:00.000Z"), AvailableCount = 1 },
            }
        ];
    }
}
