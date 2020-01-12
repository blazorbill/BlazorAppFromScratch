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
            app.UseStaticFiles();
            app.UseClientSideBlazorFiles<WASM.Startup>();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
                endpoints.MapFallbackToClientSideBlazor<WASM.Startup>("index.html");
            });
        }
    }
}
