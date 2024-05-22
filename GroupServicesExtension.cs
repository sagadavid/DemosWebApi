using FirstWebApi;
namespace DemosWebApi;

public static class GroupServicesExtension
{
  public static IServiceCollection AddServicesAtOnce(this IServiceCollection services)
  {
    services.AddScoped<IScopedService, ScopedService>();
    services.AddTransient<ITransientService, TransientService>();
    services.AddSingleton<ISingletonService, SingletonService>();

    return services;
  }
}
