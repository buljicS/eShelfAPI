using eShelfAPI.Extensions;
using DotNetEnv;

namespace eShelfAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            Env.Load("./.env");
            builder.Configuration
                .AddJsonFile($"appsettings.json", optional: false)
                .AddEnvironmentVariables();

            builder.Services.InjectServices(builder.Configuration);

            var app = builder.Build();

            app.InjectMiddlewares();

            app.Run();
        }
    }
}
