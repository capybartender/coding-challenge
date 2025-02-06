using Enpal.CodingChallenge.Core.Calendar;
using Enpal.CodingChallenge.Infrastructure.Repositories;
using Enpal.CodingChallenge.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace Enpal.CodingChallenge.Infrastructure;

public static class DependencyInjectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services
            .AddServices()
            .AddRepositories(configuration)
            .AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<Core.RootModule>());
        return services;
    }

    private static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<ICalendarService, CalendarService>();
        return services;
    }

    private static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("CodingChallengeDb");
        if (string.IsNullOrWhiteSpace(connectionString))
        {
            throw new ApplicationException("Connection string is empty");
        }
        services.AddScoped<ISlotRepository>(_ => new SlotRepository(connectionString));
        
        return services;
    }
}