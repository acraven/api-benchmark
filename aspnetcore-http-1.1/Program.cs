using Microsoft.AspNetCore.Hosting;

namespace Api.Benchmark.AspNetCore.Http
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseUrls("http://*:8121/")
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
