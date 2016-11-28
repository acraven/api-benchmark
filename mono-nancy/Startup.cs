using Owin;

namespace Api.Benchmark.Mono.Nancy
{
   public class Startup
   {
      public void Configuration(IAppBuilder app)
      {
         app.UseNancy();
      }
   }
}