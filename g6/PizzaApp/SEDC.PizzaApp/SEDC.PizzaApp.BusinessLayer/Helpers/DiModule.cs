using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SEDC.PizzaApp.DataAccess;
using SEDC.PizzaApp.DataAccess.Repositories;
using SEDC.PizzaApp.DataAccess.Repositories.CacheRepositories;
using SEDC.PizzaApp.Domain.Models;

namespace SEDC.PizzaApp.BusinessLayer.Helpers
{
    public static class DiModule
    {
        public static IServiceCollection RegisterRepositories(IServiceCollection services)
        {
            // ONE WAY OF REGISTERING DB CONTEXT
            //var connectionString = "Server=(LocalDb)\\MSSqlLocalDb;Database=PizzaDb;Trusted_Connection=True";
            //services.AddDbContext<PizzaAppContext>(options =>
            //{
            //    options.UseSqlServer(connectionString);
            //});

            //"Server=(LocalDb)\\MSSqlLocalDb;Database=PizzaDb;Trusted_Connection=True"

            services.AddTransient<IRepository<User>, UserRepository>();
            services.AddTransient<IRepository<Order>, OrderRepository>();
            services.AddTransient<IRepository<Pizza>, PizzaRepository>();
            services.AddTransient<IRepository<Feedback>, FeedbackRepository>();

            return services;
        }

        public static IServiceCollection RegisterDbContext(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<PizzaAppContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            return services;
        }
    }
}
