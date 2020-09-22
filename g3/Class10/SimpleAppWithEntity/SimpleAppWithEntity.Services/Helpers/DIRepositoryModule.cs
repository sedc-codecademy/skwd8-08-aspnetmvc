using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SimpleAppWithEntity.DataAccess;
using SimpleAppWithEntity.DataAccess.Repositories;
using SimpleAppWithEntity.DataAccess.Repositories.EntityRepositories;
using SimpleAppWithEntity.DataModels.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleAppWithEntity.Services.Helpers
{
    public static class DIRepositoryModule
    {
        // Install nugets:
        // Microsoft.Extensions.DependencyInjection 2.1.1

        // Microsoft.EntityFrameworkCore 2.1.1
        // Microsoft.EntityFrameworkCore.SqlServer 2.1.1
        public static IServiceCollection RegisterRepositories(IServiceCollection services, string connectionString) 
        {
            services.AddDbContext<NameDbContext>(x => x.UseSqlServer(connectionString));

            //register entity framewrok repositories
            services.AddTransient<IRepository<Name>, NameRepository>();

            return services;
        }
    }
}
