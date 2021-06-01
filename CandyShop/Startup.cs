using CandyShop.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop
{
    public class Startup
    {


        //?? Allows access to the Appsettings.json, for the ConnectionStrings key.
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            /* NOTE:
            Transient objects are always different; a new instance is provided to every controller and every service.

            Scoped objects are the same within a request, but different across different requests.

            Singleton objects are the same for every object and every request.
            */

            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            // Adds functionality to allow us to work with identity in our application
            // Of method IdentityUser, Allows for authentication (?)
            services.AddDefaultIdentity<IdentityUser>().AddEntityFrameworkStores<AppDbContext>();

            services.AddControllersWithViews();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICandyRepository, CandyRepository>();
            services.AddScoped<ShoppingCart>(sc => ShoppingCart.GetCart(sc));
            services.AddScoped<IOrderRepository, OrderRepository>();


            services.AddHttpContextAccessor();
            services.AddSession();

            services.AddRazorPages();


           // services.AddMvc().AddRazorPagesOptions(options =>
           //{
           //    options.Conventions.AddPageRoute("/Home/Index", "");
           //});

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            /***Middleware Setup****/

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            // **Call UseSession before routing.
            app.UseSession();


            app.UseRouting();

            // Important: Add after Routing
            app.UseAuthentication();
            app.UseAuthorization();

            //NOTE: Lets MVC respond to requests
            // Controller route is introduced to url here,
            // MyWebsite.domain/controllerName/actionName/optionalId
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                    );

                endpoints.MapRazorPages();
            });
        }
    }
}
