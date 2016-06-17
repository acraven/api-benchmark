using Microsoft.AspNetCore.Hosting;

namespace Api.Benchmark.AspNetCore.Owin.SelfHost
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseUrls("http://*:8120/")
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
