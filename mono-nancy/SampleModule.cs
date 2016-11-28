using Nancy;

namespace Api.Benchmark.Mono.Nancy
{
   public class SampleModule : NancyModule
   {
      public SampleModule()
      {
         Get["/ping"] = _ => "Pong!";
      }
   }
}