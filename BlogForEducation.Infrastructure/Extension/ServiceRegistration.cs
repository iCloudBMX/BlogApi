using BlogForEducation.Infrastructure.Context;
using BlogForEducation.Infrastructure.Interfaces;
using BlogForEducation.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BlogForEducation.Infrastructure.Extension
{
    public static class ServiceRegistration
    {
        public static void AddInfrastucture(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer
            (
                configuration.GetConnectionString("DefaultSqlServerConnection"),
                b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)
            ));

            services.AddScoped(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));
            services.AddScoped<IUserRepositoryAsync, UserRepositoryAsync>();
        }
    }
}
