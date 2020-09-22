using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SEDC.WebApp.ModelDemo.DataAccess.DB;
using SEDC.WebApp.ModelDemo.DataAccess.Domain.Interfaces;
using SEDC.WebApp.ModelDemo.DataAccess.Domain.Models;
using SEDC.WebApp.ModelDemo.DataAccess.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.WebApp.ModelDemo.Services.Helpers.DIHelper
{
    public static class DInjector
    {
        public static IServiceCollection RegisterRepositories(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PizzaDbContext>(options => options.
                UseSqlServer(configuration.GetConnectionString("PizzaAppDatabaseConnectionString")));
            services.AddTransient<IRepository<Pizza>, PizzaRepository>();
            services.AddTransient<IRepository<Order>, OrderRepository>();
            services.AddTransient<IRepository<User>, UserRepository>();
            
            return services;
        }
    }
}
