using Enpal.CodingChallenge.Contracts.Requests;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Enpal.CodingChallenge.Contracts;

public static class DependencyInjectionExtensions
{
    public static IServiceCollection AddRequestsValidation(this IServiceCollection services)
    {
        services.AddScoped<IValidator<GetAvailableAppointmentSlotsRequest>, GetAvailableAppointmentSlotsRequestValidator>();
        
        return services;
    }
}