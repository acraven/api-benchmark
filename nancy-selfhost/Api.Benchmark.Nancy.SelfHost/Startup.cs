using Owin;

namespace Api.Benchmark.Nancy.SelfHost
{
   public class Startup
   {
      public void Configuration(IAppBuilder app)
      {
         app.UseNancy();
      }
   }
}