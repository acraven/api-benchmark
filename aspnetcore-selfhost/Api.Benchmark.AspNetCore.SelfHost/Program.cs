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
                .UseContentRoot(Directory.GetCurrentDirectory())
//                .UseIISIntegration()
                .UseUrls("http://+:8100")
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
