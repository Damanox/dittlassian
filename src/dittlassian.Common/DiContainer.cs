using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dittlassian.Objects.Common;
using dittlassian.Services.Messages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace dittlassian.DI
{
    public static class DiContainer
    {
        private static bool IsInitialized { get; set; }

        public static IServiceCollection InitializeCustomServices(this IServiceCollection services)
        {
            return Initilize(services);
        }

        public static IConfigurationBuilder ConfigureCustomPaths(this IConfigurationBuilder builder)
        {
            return builder;
        }

        public static IServiceCollection Initilize(IServiceCollection serviceCollection = null)
        {
            if (IsInitialized)
                return serviceCollection;

            IsInitialized = true;

            if (serviceCollection == null)
            {
                serviceCollection = new ServiceCollection();

                var configurationBuilder = new ConfigurationBuilder().ConfigureCustomPaths();

                serviceCollection.AddSingleton<IConfiguration>(serviceProvider => configurationBuilder.Build());
            }

            serviceCollection.AddSingleton<DiscordMessageService>();

            serviceCollection.AddOptions();

            var iConfig = serviceCollection.BuildServiceProvider();

            serviceCollection.Configure<Configuration>(y =>
            {
                y.Discord = new DiscordConfiguration()
                {

                };
                y.Rules = new List<Rule>
                {
                    new Rule()
                    {
                        Condition = "abcd"
                    }
                };

                return;
            });
            // Initialize serviceCollection

            var a = serviceCollection.BuildServiceProvider().GetService<IOptions<Configuration>>();
            var a2= serviceCollection.BuildServiceProvider().GetService<Configuration>();
            return serviceCollection;
        }
    }
}