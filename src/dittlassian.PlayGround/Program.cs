using System;
using System.Collections.Generic;
using System.Dynamic;
using dittlassian.Common;
using dittlassian.DI;
using dittlassian.Objects.Common;
using dittlassian.Objects.Jira;
using dittlassian.Utilities.ConditionParser;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Internal;
using Microsoft.Extensions.Options;

namespace dittlassian.PlayGround
{
    public static class CustomLoggerHelper{
        public static void LogInformation2(this ILogger logger, Exception exception, string message, params object[] args)
        {
            if (logger == null)
                throw new ArgumentNullException(nameof(logger));
            logger.Log<object>(LogLevel.Information, (EventId)0, (object)args, exception, null);
        }
    }

    public enum TestEnum
    {
        One,
        Two
    }

    class Test
    {
        public readonly IOptions<Configuration> _conf;

        public Test(IOptions<Configuration> conf)
        {
            _conf = conf;
            var xzcds = 0;
        }
    }


    class Program
    {

        static void Main(string[] args)
        {
            var x1 = DiContainer.Initilize(null);

            x1.AddSingleton<Test>();

            var result = x1.BuildServiceProvider().GetService<Test>();
            var x = (TestEnum) 1;
            var zzz = (TestEnum) int.MaxValue;
            var zz = 0;
            try
            {
                /*Console.WriteLine("Hello World!");

                var services = new ServiceCollection();
                var logger = new LoggerFactory();

                logger.AddProvider(new ColoredConsoleLoggerProvider());

                var ab = logger.CreateLogger<Program>();

                ab.LogInformation2(null,"",new {a = 2, b = 3});

                services.AddTransient<Change1>();
                services.AddTransient<Change2>();
                services.AddTransient<DiTest>();
                services.AddSingleton<ILoggerFactory, LoggerFactory>();
                services.AddLogging(builder => { builder.AddProvider(new ColoredConsoleLoggerProvider()); });
                
                
                var provider = services.BuildServiceProvider();

                var di = provider.GetService<DiTest>();*/

                var webhook = new JiraWebHook
                {
                    Timestamp = 32834834,
                    Issue = new Issue
                    {
                        Id = "BB-1000",
                        Fields = new Fields
                        {
                            Workratio = 3,
                            CustomFields = new ExpandoObject()
                        }
                    }
                };

                var temp = webhook.Issue.Fields.CustomFields as IDictionary<string, object>;

                temp["test"] = "Test";

                var res = ConditionParserUtil.Parse("Issue.Fields.test == '2018-01-01 00:01:02'", webhook);
                
                var z = 0;
            }
            catch (Exception ex)
            {
                var a = 0;
            }

        }
    }

    public class DiTest
    {
        public DiTest(Change1 ab, Change2 qw, ILogger<DiTest> test)
        {
            var a = 0;
            test.LogInformation("abcd");
        }
    }
    public class Change1
    {
        public Change1()
        {

        }
    }
    public class Change2
    {
        public Change2(Change1 change1)
        {

        }
    }
}
