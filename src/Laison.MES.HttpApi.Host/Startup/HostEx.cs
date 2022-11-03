using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;
using System;
using _Host = Microsoft.Extensions.Hosting.Host;

namespace Laison.MES
{
    public class HostEx
    {
        public static int Run<TStartup>(string[] args) where TStartup : class
        {
            Log.Logger = new LoggerConfiguration()
#if DEBUG
                .MinimumLevel.Debug()
#else
                .MinimumLevel.Information()
#endif
                .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
                .Enrich.FromLogContext()
                .WriteTo.Console(restrictedToMinimumLevel: LogEventLevel.Debug)
                //.WriteTo.File("Logs/logs.txt", rollingInterval: RollingInterval.Day)
                .WriteTo.Logger(lg => lg.Filter.ByIncludingOnly(p => p.Level == LogEventLevel.Debug)
                   .WriteTo.File("Logs/Debug/logs.txt", rollingInterval: RollingInterval.Day))
                .WriteTo.Logger(lg => lg.Filter.ByIncludingOnly(p => p.Level == LogEventLevel.Information)
                   .WriteTo.File("Logs/Info/logs.txt", rollingInterval: RollingInterval.Day))
                .WriteTo.Logger(lg => lg.Filter.ByIncludingOnly(p => p.Level == LogEventLevel.Error)
                   .WriteTo.File("Logs/Error/logs.txt", rollingInterval: RollingInterval.Day))
                .CreateLogger();

            Log.Information("Starting web host.");

            try
            {
                CreateHostBuilder<TStartup>(args).Build().Run();
                return 0;
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Host terminated unexpectedly!");
                return 1;
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        private static IHostBuilder CreateHostBuilder<TStartup>(string[] args)
            where TStartup : class
        {
            return _Host.CreateDefaultBuilder(args)
                 .ConfigureWebHostDefaults(webBuilder =>
                 {
                     webBuilder.UseStartup<TStartup>();
                 })
                // .AsMultipleServerHostBuilder()
                // .AddServer<LoraDCUService, LapisPackage, LoraDCUPipelineFilter>(builder =>
                // {
                //     builder.ConfigureServerOptions((ctx, config) =>
                //     {
                //         return config.GetSection("LoraDcuServer");
                //     })
                //    .UseSession<LoraDCUSession>()
                //    .UseCommand(commandOptions =>
                //    {
                //        commandOptions.AddCommand<Laison645Command>();
                //        commandOptions.AddCommand<LierdaCommand>();
                //        commandOptions.AddCommand<LaisonATCommand>();
                //        commandOptions.AddCommand<DLT645Command>();
                //    });
                // })
                // .AddServer<GprsService, LapisPackage, AMIMeterPipelineFilter>(builder =>
                // {
                //     builder.ConfigureServerOptions((ctx, config) =>
                //     {
                //         return config.GetSection("GprsServer");
                //     })
                //    .UseSession<AMIMeterSession>()
                //    .UseCommand(commandOptions =>
                //    {
                //        commandOptions.AddCommand<Laison645Command>();
                //    });
                // })
                //.AddServer<NBIotService, LapisPackage, AMIMeterPipelineFilter>(builder =>
                //{
                //    builder.ConfigureServerOptions((ctx, config) =>
                //    {
                //        return config.GetSection("NBIotServer");
                //    })
                //    .UseSession<AMIMeterSession>()
                //    .UseCommand(commandOptions =>
                //    {
                //        commandOptions.AddCommand<Laison645Command>();
                //    })
                //    .UseUdp();
                //})
                .UseAutofac()
                .UseSerilog();
        }
    }
}