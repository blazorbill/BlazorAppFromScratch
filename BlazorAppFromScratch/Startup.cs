using BlazorAppFromScratch.Server.BL.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppFromScratch
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IPersonService, PersonService>();
            services.AddControllers();
        }
        public void Configure(IApplicationBuilder app)
        {
            app.UseCors(builder =>
            {
                builder.WithOrigins("https://localhost:44379");
            });
            app.UseStaticFiles();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
                endpoints.MapFallbackToFile("index.html");
            });
        }
    }
}
