using System.Reflection;

using GymManager.Application.Common.Behaviours;

using MediatR;

using Microsoft.Extensions.DependencyInjection;

namespace GymManager.Application;
public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());

        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(LoggingBehaviour<,>));

        return services;
    }
}
