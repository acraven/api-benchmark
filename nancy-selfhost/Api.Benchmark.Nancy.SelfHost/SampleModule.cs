using Nancy;

namespace Api.Benchmark.Nancy
{
   public class SampleModule : NancyModule
   {
      public SampleModule()
      {
         Get["/"] = _ => "Hello World!";
      }
   }
}