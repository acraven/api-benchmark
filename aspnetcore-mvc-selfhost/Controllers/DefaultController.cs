using Microsoft.AspNetCore.Mvc;

namespace Api.Benchmark.AspNetCore.SelfHost.Controllers
{
    public class DefaultController : Controller
    {
        [Route("/ping")]
        public string Ping()
        {
            return "Pong!";
        }
    }
}
