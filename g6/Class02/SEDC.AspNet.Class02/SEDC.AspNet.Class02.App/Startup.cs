using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SEDC.AspNet.Class02.App
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseCookiePolicy();

            //http://localhost:62833/post/ReadPostById/4
            //http://localhost:62833/post/ReadPostByName/Tosho

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                //routes.MapRoute(
                //    name: "test_route",
                //    template: "post/read-post/{id:int}",
                //    defaults: new { controller = "Post", action = "ReadPostById" });

                //routes.MapRoute(
                //    name: "test_route1",
                //    template: "post/read-post/{id:alpha}",
                //    defaults: new { controller = "Post", action = "ReadPostByName" });

                //routes.MapRoute(
                //    name: "test_route1",
                //    template: "post/read-post/{id:alpha:minlength(6)}",
                //    defaults: new { controller = "Post", action = "ReadPostByName" });

                //routes.MapRoute(
                //    name: "test_route_constraint2",
                //    template: "post/read-post/",
                //    defaults: new { controller = "Post", action = "Index" });

                //routes.MapRoute(
                //    name: "test_route_constraint",
                //    template: "post/read-post/{id}",
                //    defaults: new { controller = "Post", action = "ReadPostById" },
                //    constraints: new { Id = new IntRouteConstraint() });

                //routes.MapRoute(
                //    name: "test_route_constraint1",
                //    template: "post/read-post/{id}",
                //    defaults: new { controller = "Post", action = "ReadPostByName" },
                //    constraints: new { Id = new AlphaRouteConstraint() });

                //routes.MapRoute(
                //    name: "test_route_constraint1",
                //    template: "post/read-post/{id}",
                //    defaults: new { controller = "Post", action = "ReadPostByName" },
                //    constraints: new { Id = new CompositeRouteConstraint(
                //        new IRouteConstraint[]
                //        {
                //            new AlphaRouteConstraint(),
                //            new MinLengthRouteConstraint(6)
                //        }) }
                //    );
            });
        }
    }
}
