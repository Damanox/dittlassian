using System;
using System.Collections.Generic;
using System.Dynamic;
using dittlassian.Objects.Jira;
using dittlassian.Utilities.ConditionParser;
using Microsoft.Extensions.DependencyInjection;

namespace dittlassian.PlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Console.WriteLine("Hello World!");

                var services = new ServiceCollection();

                services.AddTransient<Change1>();
                services.AddTransient<Change2>();
                services.AddTransient<DiTest>();

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
        public DiTest(Change1 ab, Change2 qw)
        {
            var a = 0;
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
