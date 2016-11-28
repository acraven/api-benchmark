using System;
using Microsoft.Owin.Hosting;
using System.Threading;

namespace Api.Benchmark.Mono.Nancy
{
   class Program
   {
      static void Main(string[] args)
      {
         var url = "http://*:8140";

         Console.CancelKeyPress += (sender, eventArgs) =>
         {
            Console.WriteLine("exiting...");
         };

         using (WebApp.Start<Startup>(url))
         {
            Console.WriteLine("Running on {0}", url);
            Console.WriteLine("Press Ctrl-C to exit");
            Thread.Sleep(Timeout.Infinite);
         }
      }
   }
}
