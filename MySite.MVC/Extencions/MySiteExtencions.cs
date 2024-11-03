using MySite.BL.Abstract;
using MySite.BL.Concrete;

namespace MySite_MVC.Extencions;
public static class TicariExtensions
{
    public static IServiceCollection AddTicariService(this IServiceCollection services)
    {

        services.AddScoped(typeof(IManager<>), typeof(Manager<>));

        return services;
    }
}
