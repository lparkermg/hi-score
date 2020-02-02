// <copyright file="Program.cs" company="Luke Parker">
// Copyright (c) Luke Parker. All rights reserved.
// </copyright>

namespace Hiscore.ApiHost
{
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Hosting;

    /// <summary>
    /// Core class for the ApiHost.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main entrypoint for ApiHost application.
        /// </summary>
        /// <param name="args">An array of arguments passed in on startup.</param>
        internal static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Creates and sets up the host builder ready to be run.
        /// </summary>
        /// <param name="args">An array of arguments passed in when run.</param>
        /// <returns>Returns a host builder.</returns>
        internal static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
