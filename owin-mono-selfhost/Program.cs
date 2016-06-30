using System;
using Microsoft.Owin.Hosting;
using Owin;

namespace Api.Benchmark.Owin.Mono.SelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = "http://*:8130";

            using (WebApp.Start<Startup>(url))
            {
                Console.WriteLine("Running on {0}", url);
                Console.WriteLine("Press enter to exit");
                Console.ReadLine();
            }
        }
    }

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Run(context =>
            {
                context.Response.ContentType = "text/plain";
                return context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
