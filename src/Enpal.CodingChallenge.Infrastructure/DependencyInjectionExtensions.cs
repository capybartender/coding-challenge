using Enpal.CodingChallenge.Core.Calendar;
using Enpal.CodingChallenge.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Enpal.CodingChallenge.Infrastructure;

public static class DependencyInjectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services
            .AddServices()
            .AddMediatR(configuration => configuration.RegisterServicesFromAssemblyContaining<Core.RootModule>());
        return services;
    }

    private static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<ICalendarService, CalendarService>();

        return services;
    }
}