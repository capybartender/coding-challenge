using Enpal.CodingChallenge.Contracts;
using Enpal.CodingChallenge.Contracts.Requests;

namespace Enpal.CodingChallenge.Api.Tests.TestDataGenerators;

public sealed class TestRequestsGenerator
{
    public static IEnumerable<object[]> GetInvalidRequests()
    {
        yield return
        [
            new GetAvailableAppointmentSlotsRequest()
            {
                Date = DateOnly.FromDateTime(DateTime.Now),
                Language = null!,
                Rating = Constants.Ratings.First(),
                Products = [Constants.Products.First()],
            }
        ];

        yield return
        [
            new GetAvailableAppointmentSlotsRequest()
            {
                Date = DateOnly.FromDateTime(DateTime.Now),
                Language = "",
                Rating = Constants.Ratings.First(),
                Products = [Constants.Products.First()],
            },
        ];

        yield return
        [
            new GetAvailableAppointmentSlotsRequest()
            {
                Date = DateOnly.FromDateTime(DateTime.Now),
                Language = "Italian",
                Rating = Constants.Ratings.First(),
                Products = [Constants.Products.First()],
            },
        ];

        yield return
        [
            new GetAvailableAppointmentSlotsRequest()
            {
                Date = DateOnly.FromDateTime(DateTime.Now),
                Language = Constants.Languages.First(),
                Rating = null!,
                Products = [Constants.Products.First()],
            },
        ];

        yield return
        [
            new GetAvailableAppointmentSlotsRequest()
            {
                Date = DateOnly.FromDateTime(DateTime.Now),
                Language = Constants.Languages.First(),
                Rating = "",
                Products = [Constants.Products.First()],
            },
        ];

        yield return
        [
            new GetAvailableAppointmentSlotsRequest()
            {
                Date = DateOnly.FromDateTime(DateTime.Now),
                Language = Constants.Languages.First(),
                Rating = "Platinum",
                Products = [Constants.Products.First()],
            }
        ];

        yield return
        [
            new GetAvailableAppointmentSlotsRequest()
            {
                Date = DateOnly.FromDateTime(DateTime.Now),
                Language = Constants.Languages.First(),
                Rating = Constants.Ratings.First(),
                Products = null!,
            },
        ];

        yield return
        [
            new GetAvailableAppointmentSlotsRequest()
            {
                Date = DateOnly.FromDateTime(DateTime.Now),
                Language = Constants.Languages.First(),
                Rating = Constants.Ratings.First(),
                Products = [],
            },
        ];

        yield return
        [
            new GetAvailableAppointmentSlotsRequest()
            {
                Date = DateOnly.FromDateTime(DateTime.Now),
                Language = Constants.Languages.First(),
                Rating = Constants.Ratings.First(),
                Products = [null!],
            }
        ];
        
        
        yield return
        [
            new GetAvailableAppointmentSlotsRequest()
            {
                Date = DateOnly.FromDateTime(DateTime.Now),
                Language = Constants.Languages.First(),
                Rating = Constants.Ratings.First(),
                Products = ["Fan"],
            }
        ];
    }
}