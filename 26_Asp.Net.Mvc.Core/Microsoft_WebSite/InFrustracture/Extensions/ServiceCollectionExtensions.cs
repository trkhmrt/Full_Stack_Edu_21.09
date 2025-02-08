using MicrosoftWebSite.Business.Interfaces;
using MicrosoftWebSite.Business.Services;

namespace Microsoft_WebSite.InFrustracture.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IAboutUsService,AboutUsService>();
        services.AddScoped<IOurServiceService,OurServiceService>();
        services.AddScoped<IHomeService,HomeService>();
        services.AddScoped<IPricingService,PricingService>();
        services.AddScoped<IAuthService,AuthService>();

        return services;
    }
}