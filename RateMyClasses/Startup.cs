using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using RateMyClasses.Models;

namespace RateMyClasses
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
            services.AddMvc();
            services.AddDbContext<StudentContext>(options =>
                options.UseSqlite("Data Source=RateMyClasses.db"));
            services.AddDbContext<CourseContext>(options =>
                options.UseSqlite("Data Source=RateMyClasses.db"));
            services.AddDbContext<ReviewContext>(options =>
                options.UseSqlite("Data Source=RateMyClasses.db"));
            services.AddDbContext<ReportContext>(options =>
                options.UseSqlite("Data Source=RateMyClasses.db"));
            services.AddDbContext<ModeratorsContext>(options =>
                options.UseSqlite("Data Source=RateMyClasses.db"));

            services.AddScoped<IDbContext, RateMyClasses.Models.ReviewContext>();


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

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}