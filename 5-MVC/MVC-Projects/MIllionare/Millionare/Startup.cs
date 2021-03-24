using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Millionare.Filters;
using Millionare.Models;
using Millionare.Services;
using Millionare.Services.Implementations;
using Millionare.Services.Interfaces;
using System;

namespace Millionare
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
            services.AddSingleton<IRepository<Question>, QuestionRepository>();
            services.AddSingleton<IRepository<User>, UserRepository>();
            services.AddSingleton<IRepository<History>, HistoryRepository>();
            services.AddSingleton<IGameService, GameService>();



            services.AddScoped<IQuestionService, QuestionService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAuthService, AuthService>();

            services.ConfigureApplicationCookie(options => options.ExpireTimeSpan = TimeSpan.FromMinutes(5));

            services.AddMvc(options => options.Filters.Add(typeof(CustomSecurityFilter)));


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
