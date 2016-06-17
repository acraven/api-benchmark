using Microsoft.AspNetCore.Mvc;

namespace Api.Benchmark.AspNetCore.SelfHost.Controllers
{
    public class DefaultController : Controller
    {
        [Route("/")]
        public string Get()
        {
            return "Hello World!";
        }
    }
}
