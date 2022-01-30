using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MyFirstCoreAPI.Middleware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstCoreAPI
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
            services.AddControllers();
            //services.AddSwaggerGen(option => {
            //    option.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo() { 
            //    Title="Raja Swagg",
            //    Description="Raja swagg desc",
            //    Version="v1"
            //    });
            //});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //if (env.IsDevelopment())
            //{

            //Added By Karthi from branch1

            //app.UseDeveloperExceptionPage();
            //}


            app.UseRouting();
            app.UseStaticFiles();
             app.UseAuthorization();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllers();
            //});
            //app.UseSwagger();
            //app.UseSwaggerUI(option=>
            //{
            //    option.SwaggerEndpoint("/swagger/v1/swagger.json", "Raja Swagg demo");
            //});
            app.UseFirstMiddleware();

            //app.UseHttpsRedirection();
            //app.UseStaticFiles();
            //app.UseCookiePolicy();

            //app.UseRouting();
            //app.UseRequestLocalization();
            //app.UseCors();

            //app.UseAuthentication();
            //app.UseAuthorization();
            //app.UseSession();
            //app.UseResponseCompression();
            //app.UseResponseCaching();
            //app.UseResponseCaching();
            //app.UseResponseCompression();
            //app.UseStaticFiles();
            //app.UseDeveloperExceptionPage();
            //app.UseDatabaseErrorPage();
            //app.UseExceptionHandler("/Error");
            //app.UseHsts();
            //app.UseHttpsRedirection();
            //app.UseStaticFiles();
            //app.UseCookiePolicy();
            //app.UseRouting();
            //app.UseAuthentication();
            //app.UseAuthorization();
            //app.UseSession();
           
            //app.UseRouting();
            //app.UseResponseCompression();



        }
    }
}
