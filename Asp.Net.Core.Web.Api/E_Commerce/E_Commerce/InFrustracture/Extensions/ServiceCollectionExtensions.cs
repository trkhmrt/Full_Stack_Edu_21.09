using E_Commerce.Business.Interface;
using E_Commerce.Business.Service;

namespace E_Commerce.InFrustracture.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInFrustracture(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IUserService, UserService>();
        serviceCollection.AddScoped<IProductService, ProductService>();






        return serviceCollection;
    }
    
}