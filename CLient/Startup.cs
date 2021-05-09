using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Client.Data.AdultService;
using Client.Data.ChildrenService;
using Client.Data.FamilyService;
using Client.Data.UserService;
using Microsoft.AspNetCore.Components.Authorization;

namespace CLient
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddScoped<IFamilyService, FamilyService>();
            services.AddScoped<IAdultService, AdultService>();
            services.AddScoped<IChildrenService, ChildrenService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();

            services.AddAuthorization(options =>
            {
                options.AddPolicy("AdminRole", a => 
                    a.RequireAuthenticatedUser().RequireClaim("Role", "Admin"));
                options.AddPolicy("EditorRole", a => 
                    a.RequireAuthenticatedUser().RequireClaim("Role", "Editor"));
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}