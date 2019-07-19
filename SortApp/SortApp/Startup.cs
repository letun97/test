using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using SortApp.Models;
using Microsoft.EntityFrameworkCore;

namespace SortApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            string connection = "Server = (localdb)\\mssqllocaldb; Database = userstoredb; Trusted_Connection = True; MultipleActiveResultSets = true";
            services.AddDbContext<UsersContext>(options =>
                options.UseSqlServer(connection));
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}