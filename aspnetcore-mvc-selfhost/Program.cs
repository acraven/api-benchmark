using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Api.Benchmark.AspNetCore.SelfHost
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseUrls("http://*:8105")
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
