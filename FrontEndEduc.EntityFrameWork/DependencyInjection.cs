using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace FrontEndEduc.EntityFrameWork
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(opt =>
            {
                opt.UseNpgsql(configuration.GetConnectionString("postgres"),
                options =>
                {
                    options.EnableRetryOnFailure();
                    options.CommandTimeout(180);
                });
            });
            return services;
        }
    }
}