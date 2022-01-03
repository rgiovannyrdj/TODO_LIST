using Microsoft.Extensions.DependencyInjection;
using TODOLIST.CORE.Interfaces.IRepositories;
using TODOLIST.CORE.Interfaces.IServices;
using TODOLIST.CORE.Services;
using TODOLIST.INFRASTRUCTURE.Repositories;

namespace TODOLIST.INFRASTRUCTURE.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(ITareaRepository), typeof(TareaRepository));
            services.AddTransient<ITareaService, TareaService>();
            return services;
        }
    }
}
