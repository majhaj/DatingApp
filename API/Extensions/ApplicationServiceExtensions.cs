using System.Reflection.Metadata.Ecma335;
using API.Data;
using API.Interfaces;
using API.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, 
                                                                IConfiguration config)
        {
            services.AddDbContext<DatabaseContext>(opt => 
            {
                opt.UseSqlite(config.GetConnectionString("DefaultConnection"));
            });
            services.AddCors();

            services.AddScoped<ITokenService, TokenService>();

            return services;
        }
    }
}