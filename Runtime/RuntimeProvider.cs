using System;
using BenjaminAbt.Samples.WinFormsSpsRxNet.Forms;
using BenjaminAbt.Samples.WinFormsSpsRxNet.Providers;
using BenjaminAbt.Samples.WinFormsSpsRxNet.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BenjaminAbt.Samples.WinFormsSpsRxNet.Runtime
{
    public class RuntimeProvider
    {
        public IServiceProvider ServiceProvider { get; set; }

        public RuntimeProvider()
        {
            
            ServiceCollection services = new ServiceCollection();

            // Register Demo Connection
            services.AddSingleton<ISpsConnection, InMemoryDemoSpsConnection>();


            // Register Demo Connection
            services.AddSingleton<ISpsService, SpsService>();

            // Forms
            services.AddTransient<DemoForm>();

            // Register SPS Demo Service
            ServiceProvider = services.BuildServiceProvider();
        }
    }
}
