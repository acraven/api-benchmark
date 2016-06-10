using Owin;

namespace Api.Benchmark.Nancy
{
   public class Startup
   {
      public void Configuration(IAppBuilder app)
      {
         app.UseNancy();
      }
   }
}