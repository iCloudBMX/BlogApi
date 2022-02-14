using BlogForEducation.Application.Interfaces;
using BlogForEducation.Application.Profiles;
using BlogForEducation.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BlogForEducation.Application.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddAplicationLayer(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingInitializer));
            services.AddTransient<IUserService, UserService>();
        }
    }
}
