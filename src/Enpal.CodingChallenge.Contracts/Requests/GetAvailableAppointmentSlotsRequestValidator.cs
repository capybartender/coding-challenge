using FluentValidation;

namespace Enpal.CodingChallenge.Contracts.Requests;

public sealed class GetAvailableAppointmentSlotsRequestValidator 
    : AbstractValidator<GetAvailableAppointmentSlotsRequest>
{
    public GetAvailableAppointmentSlotsRequestValidator()
    {
        RuleFor(request => request.Products)
            .NotNull()
            .NotEmpty()
            .Must(products => products.All(p => Constants.Products.Contains(p)));

        RuleFor(request => request.Language)
            .NotNull()
            .NotEmpty()
            .Must(language => Constants.Languages.Contains(language));

        RuleFor(request => request.Rating)
            .NotNull()
            .NotEmpty()
            .Must(rating => Constants.Ratings.Contains(rating));

        // NOTE: In case of real system I would also add the following check
        // RuleFor(request => request.Date).GreaterThanOrEqualTo(DateOnly.FromDateTime(DateTime.UtcNow));
    }
}