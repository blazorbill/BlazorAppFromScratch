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
            services.AddServerSideBlazor();
            services.AddRazorPages();
        }
        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
