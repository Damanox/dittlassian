using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace dittlassian.DI
{
    public static class DiContainer
    {
        private static bool IsInitialized { get; set; }

        public static IServiceCollection InitializeCustomServices(this IServiceCollection services)
        {
            return Initilize(services);
        }

        public static IServiceCollection Initilize(IServiceCollection serviceCollection = null)
        {
            if (IsInitialized)
                return serviceCollection;

            IsInitialized = true;
            var selfInitialized = false;

            if (serviceCollection == null)
            {
                serviceCollection = new ServiceCollection();
                selfInitialized = true;
            }

            // Initialize serviceCollection

            if (selfInitialized)
                serviceCollection.BuildServiceProvider();

            return serviceCollection;
        }
    }
}