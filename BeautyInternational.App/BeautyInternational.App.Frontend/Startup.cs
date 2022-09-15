using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BeautyInternational.App.Persistencia;


namespace BeautyInternational.App.Frontend
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
            services.AddRazorPages();
            services.AddControllersWithViews();
            services.AddDbContext<BeautyInternational.App.Persistencia.AppContext>();
            /*services.AddDbContext<BeautyInternational.App.Persistencia.AppContext>();
            services.AddSingleton<IRepositorioClsAdministrador, RepositorioClsAdministrador>();
            services.AddSingleton<IRepositorioClsCita, RepositorioClsCita>();
            services.AddSingleton<IRepositorioClsAdministrador, RepositorioClsAdministrador>();
            services.AddSingleton<IRepositorioClsCliente, RepositorioClsCliente>();
            services.AddSingleton<IRepositorioClsLogueo, RepositorioClsLogueo>();
            services.AddSingleton<IRepositorioClsPersona, RepositorioClsPersona>();
            services.AddSingleton<IRepositorioClsProfesional, RepositorioClsProfesional>();*/
            /*services.AddSingleton<IRepositorioClsServicio, RepositorioClsServicio>();*/
            /*services.AddSingleton<IRepositorioClsHistoria, RepositorioClsHistoria>();*/
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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
