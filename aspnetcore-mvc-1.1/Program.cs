using Microsoft.AspNetCore.Hosting;

namespace Api.Benchmark.AspNetCore.Mvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseUrls("http://*:8111")
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
