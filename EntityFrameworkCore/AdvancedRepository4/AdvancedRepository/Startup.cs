using AdvancedRepository.Models.Data;
using AdvancedRepository.Models.Views;
using AdvancedRepository.Repository.Classes;
using AdvancedRepository.Repository.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository
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
            services.AddDbContext<SirketContext>(op => op.UseSqlServer(Configuration.GetConnectionString("Connection")));
            services.AddScoped<IProductsRepos, ProductsRepos>();
            services.AddScoped<ICategoriesRepos, CategoriesRepos>();
            services.AddScoped<ISuppliersRepos, SuppliersRepos>();
            services.AddScoped<IUnitsRepos, UnitsRepos>();
            services.AddScoped<CategoriesModel>();
            services.AddScoped<ProductsModel>();
            services.AddScoped<UnitsModel>();
            services.AddScoped<SuppliersModel>();
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
            }
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
