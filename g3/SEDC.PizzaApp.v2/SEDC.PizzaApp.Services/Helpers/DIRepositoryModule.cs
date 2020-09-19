using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using SEDC.PizzaApp.DataAccess.Repositories;
using SEDC.PizzaApp.DataAccess.Repositories.CashRepositories;
using SEDC.PizzaApp.DomainModels.Models;

namespace SEDC.PizzaApp.Services.Helpers
{
    public static class DIRepositoryModule
    {
        // Install nugets:
        // Microsoft.Extensions.DependencyInjection 2.1.1
        public static IServiceCollection RegisterRepositories(IServiceCollection services) 
        {
            //StaticDB repositories dependencies
            services.AddTransient<IRepository<Pizza>, PizzaRepository>();
            services.AddTransient<IRepository<Order>, OrderRepository>();
            services.AddTransient<IRepository<User>, UserRepository>();

            //Entity repostiores dependencies

            return services;
        }
    }
}
