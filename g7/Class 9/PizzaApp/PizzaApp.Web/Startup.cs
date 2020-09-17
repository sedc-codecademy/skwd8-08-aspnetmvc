using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PizzaApp.DataAccess.Core.Entities;
using PizzaApp.DataAccess.Db.DbAccess;
using PizzaApp.DataAccess.Db.Interfaces;
using PizzaApp.DataAccess.Repositorties.BasicRepositories;
using PizzaApp.DataAccess.Repositorties.Interfaces;
using PizzaApp.Services.Services.BasicServices;
using PizzaApp.Services.Services.Interfaces;

namespace PizzaApp.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllersWithViews();

            services.AddSingleton<IDb, LocalDb>();

            services.AddTransient<IRepository<User>, UserRepository>();
            services.AddTransient<IRepository<Order>, OrderRepository>();
            services.AddTransient<IRepository<Pizza>, PizzaRepository>();

            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IPizzaService, PizzaService>();
            services.AddTransient<IDbContext, PizzaDbAccessContext>();
           // string connectionString = "Data Source = localhost\\SQLEXPRESS; Database = PizzaAppDb; Integrated Security = True;";
            services.AddDbContext<PizzaDbAccessContext>(options => options.
                UseSqlServer(Configuration.GetConnectionString("MyConnectionString")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
