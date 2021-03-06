﻿using System;
using Microsoft.Owin.Hosting;
using Owin;
using System.Threading;

namespace Api.Benchmark.Mono.Owin
{
   class Program
   {
      static void Main(string[] args)
      {
         var url = "http://*:8130";

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

   public class Startup
   {
      public void Configuration(IAppBuilder app)
      {
         app.Map("/ping", builder =>
         {
            builder.Run(context =>
            {
               context.Response.ContentType = "text/plain";
               return context.Response.WriteAsync("Pong!");
            });
         });
      }
   }
}
