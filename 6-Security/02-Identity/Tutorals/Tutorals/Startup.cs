using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Tutorals.Data;

namespace Tutorals
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
            services.AddScoped<SignInManager<IdentityUser<int>>>();
            services.AddScoped<UserManager<IdentityUser<int>>>();
            //services.AddScoped<RoleManager<IdentityRole<int>>>();

            services.AddIdentity<IdentityUser<int>, IdentityRole<int>>(config =>
            {
                config.Password.RequiredLength = 5;
            })
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();
            services.ConfigureApplicationCookie(config =>
            {
                config.Cookie.Name = "app_cookie";
                config.LoginPath = "/Account/Login";
            });

            services.AddAuthorization(config =>
            {
                config.DefaultPolicy = new AuthorizationPolicyBuilder()
                                            .RequireAuthenticatedUser()
                                            .RequireClaim(ClaimTypes.Name)
                                            .Build();
                config.AddPolicy("OnlyAdmin", p => {
                    p.RequireRole("Admin");
                });
                config.AddPolicy("OnlyUser", p => {
                    p.RequireUserName("User");
                });
            });

            services.AddControllersWithViews();
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("AppDatabase"));
            });
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

            app.UseAuthentication();
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
