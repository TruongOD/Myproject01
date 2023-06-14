using Microsoft.AspNetCore.Mvc.Infrastructure;
using Myproject01.Services;
using Myproject01.Services.Implements;

namespace Myproject01.Infrastructure.Dependencies
{
    public class IoC
    {
        public static void Register(IServiceCollection services, IConfiguration configuration)
        {
            // -- Ultilities --
            // Http
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            // Action context
            services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();
            // httpclient
            services.AddSingleton<HttpClient, HttpClient>();

            services.AddScoped<IProductSevice,ProductSevice>();
            services.AddScoped<IBrandService,BrandService>();
        }
    }
}
