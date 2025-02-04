using FluentValidation;

namespace Enpal.CodingChallenge.Contracts.Requests;

public class GetAvailableAppointmentSlotsRequestValidator : AbstractValidator<GetAvailableAppointmentSlotsRequest>
{
    public GetAvailableAppointmentSlotsRequestValidator()
    {
        RuleFor(request => request.Products).NotEmpty();
        RuleFor(request => request.Language).NotNull().NotEmpty();
        RuleFor(request => request.Rating).NotNull().NotEmpty();
        
        // NOTE: for Language and request I would also check the values
        // In case of production system I would also add the following check
        // RuleFor(request => request.Date).GreaterThanOrEqualTo(DateOnly.FromDateTime(DateTime.UtcNow));
    }
}