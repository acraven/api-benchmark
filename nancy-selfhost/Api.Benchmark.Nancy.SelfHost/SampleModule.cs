﻿using Nancy;

namespace Api.Benchmark.Nancy.SelfHost
{
   public class SampleModule : NancyModule
   {
      public SampleModule()
      {
         Get["/"] = _ => "Hello World!";
      }
   }
}