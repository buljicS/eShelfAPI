using eShelfAPI.Context;
using Microsoft.EntityFrameworkCore;


namespace eShelfAPI.Extensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection InjectServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MainContext>(op => op.UseSqlServer(configuration.GetConnectionString("MainDB")));
            services.AddControllers();
            services.AddSwaggerGen();

            return services;
        }
    }
}
