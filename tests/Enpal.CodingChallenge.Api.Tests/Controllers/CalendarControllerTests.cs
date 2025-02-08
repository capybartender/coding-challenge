using Enpal.CodingChallenge.Api.Controllers;
using Enpal.CodingChallenge.Api.Tests.TestDataGenerators;
using Enpal.CodingChallenge.Contracts;
using Enpal.CodingChallenge.Contracts.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;

namespace Enpal.CodingChallenge.Api.Tests.Controllers;

public sealed class CalendarControllerTests
{
    private readonly IMediator _mediator = Substitute.For<IMediator>();
    
    [Fact]
    public async Task Query_Should_ReturnOkObjectResult()
    {
        // Arrange
        var sut = new CalendarController(_mediator);
        var request = new GetAvailableAppointmentSlotsRequest()
        {
            Date = DateOnly.FromDateTime(DateTime.Now),
            Language = Constants.Languages.First(),
            Rating = Constants.Ratings.First(),
            Products = [Constants.Products.First()],
        };

        //Act
        var result = await sut.QueryAvailableAppointmentSlots(request, CancellationToken.None);

        //Assert
        Assert.IsType<OkObjectResult>(result.Result);
    }

    [Theory]
    [MemberData(nameof(TestRequestsGenerator.GetInvalidRequests), MemberType = typeof(TestRequestsGenerator))]
    public async Task Query_Should_ReturnBadRequestObjectResult(GetAvailableAppointmentSlotsRequest request)
    {
        // Arrange
        var sut = new CalendarController(_mediator);

        //Act
        var result = await sut.QueryAvailableAppointmentSlots(request, CancellationToken.None);

        //Assert
        Assert.IsType<BadRequestObjectResult>(result.Result);
    }
}