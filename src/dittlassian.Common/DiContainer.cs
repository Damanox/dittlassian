using dittlassian.Common.Models;
using dittlassian.Objects.Common;
using dittlassian.Services.Messages;
using dittlassian.Utilities.ConditionParser;
using DSharpPlus;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace dittlassian.Common
{
    public static class DiContainer
    {
        private static bool IsInitialized { get; set; }

        public static IServiceCollection AddCustomServices(this IServiceCollection services)
        {
            return Initialize(services);
        }

        public static IConfigurationBuilder AddCustomPaths(this IConfigurationBuilder builder)
        {
            builder.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile("bot.config.json", optional: false, reloadOnChange: true);

            int.TryParse(builder.Build()["Environment"], out var result);

            var currentEnvironment = (Environment) result;

            builder.AddJsonFile($"bot.{currentEnvironment.ToString().ToLowerInvariant()}.config.json", optional: true,
                reloadOnChange: true)
                .AddJsonFile($"appsettings.{currentEnvironment.ToString().ToLowerInvariant()}.json", optional:true, reloadOnChange:true);

            return builder;
        }

        public static IServiceCollection Initialize(IServiceCollection serviceCollection = null)
        {
            if (IsInitialized)
                return serviceCollection;

            IsInitialized = true;

            if (serviceCollection == null)
            {
                serviceCollection = new ServiceCollection();

                var configurationBuilder = new ConfigurationBuilder().AddCustomPaths();

                serviceCollection.AddSingleton<IConfiguration>(serviceProvider => configurationBuilder.Build());
            }

            serviceCollection.AddOptions();

            serviceCollection.AddScoped<DiscordMessageService>();
            serviceCollection.AddSingleton<ConditionParser>();

            var iConfig = serviceCollection.BuildServiceProvider().GetService<IConfiguration>();

            serviceCollection.Configure<Configuration>(iConfig);

            var a = serviceCollection.BuildServiceProvider().GetService<IOptions<Configuration>>().Value;

            serviceCollection.AddScoped<DiscordClient>(y => new DiscordClient(new DSharpPlus.DiscordConfiguration()
            {
                AutoReconnect = true,
                AutomaticGuildSync = true,
                EnableCompression = true,
                TokenType = TokenType.Bot,
                Token = a.Discord.Token
            }));

            return serviceCollection;
        }
    }
}