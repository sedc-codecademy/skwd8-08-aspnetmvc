using Microsoft.Extensions.DependencyInjection;
using SEDC.PizzaApp.DataAccess.Repositories;
using SEDC.PizzaApp.DataAccess.Repositories.CacheRepositories;
using SEDC.PizzaApp.Domain.Models;

namespace SEDC.PizzaApp.BusinessLayer.Helpers
{
    public static class DiModule
    {
        public static IServiceCollection RegisterRepositories(IServiceCollection services)
        {
            services.AddTransient<IRepository<User>, UserRepository>();
            services.AddTransient<IRepository<Order>, OrderRepository>();
            services.AddTransient<IRepository<Pizza>, PizzaRepository>();
            services.AddTransient<IRepository<Feedback>, FeedbackRepository>();

            return services;
        }
    }
}
