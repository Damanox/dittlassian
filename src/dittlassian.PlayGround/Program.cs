using System;
using Microsoft.Extensions.DependencyInjection;

namespace dittlassian.PlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello World!");

                var services = new ServiceCollection();

                services.AddTransient<Change1>();
                services.AddTransient<Change2>();
                services.AddTransient<DiTest>();

                var provider = services.BuildServiceProvider();

                var di = provider.GetService<DiTest>();
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
