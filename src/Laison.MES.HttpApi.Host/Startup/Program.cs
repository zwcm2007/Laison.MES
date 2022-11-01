using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Laison.MES.Application.Contracts;
using Laison.MES.Application;
using AntDesign.ProLayout;

namespace Laison.MES
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddAntDesign();
            builder.Services.Configure<ProSettings>(builder.Configuration.GetSection("ProSettings"));
            //builder.Services.AddScoped<IChartService, ChartService>();
            //builder.Services.AddScoped<IProjectService, ProjectService>();
            builder.Services.AddScoped<IUserAppService, UserAppService>();
            builder.Services.AddScoped<IAccountService, AccountService>();
            //builder.Services.AddScoped<IProfileService, ProfileService>();

            await builder.Build().RunAsync();

            //return HostEx.Run<Startup>(args);
        }
    }
}