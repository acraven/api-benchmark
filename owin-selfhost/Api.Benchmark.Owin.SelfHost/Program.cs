using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Owin;
using Microsoft.Owin.Hosting;
using Owin;

namespace Api.Benchmark.Owin.SelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = "http://localhost:8090";

            using (WebApp.Start<Startup>(url))
            {
                Console.WriteLine("Running on {0}", url);
                Console.WriteLine("Press enter to exit");
                Console.ReadLine();
            }
        }
    }

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.ForRoute("GET", "/", builder =>
                {
                    builder.Run(context =>
                        {
                            context.Response.StatusCode = (int)HttpStatusCode.OK;
                            context.Response.ContentType = "text/plain";
                            context.Response.Write("Hello World!");
                            context.Response.Headers.Append("Connection", "Keep-Alive");
                            return Task.CompletedTask;
                        });
                });
        }
    }

    public static class AppBuilderExtensions
    {
        private const string RequestParams = "_requestParams";

        public static IAppBuilder ForRoute(this IAppBuilder app, string method, string route, Action<IAppBuilder> configuration)
        {
            Func<IOwinContext, bool> predicate = context => Match(method, route, context.Request.Method, context.Request.Path.Value, context);
            app.MapWhen(c => c.Request.Method == "OPTIONS" && predicate(c), a => a.Run(c => Task.CompletedTask));
            app.MapWhen(predicate, configuration);
            return app;
        }

        private static bool Match(string method, string url, string requestMethod, string requestUrl, IOwinContext context)
        {
            url = url.Trim('/');
            requestUrl = requestUrl.Trim('/');
            Func<string, string, bool> equals = (s1, s2) => string.Equals(s1, s2, StringComparison.OrdinalIgnoreCase);
            if (!equals(requestMethod, "OPTIONS") && !equals(method.ToString(), requestMethod))
            {
                return false;
            }
            var regex = new Regex("^" + url.Replace("{", "(?<").Replace("}", ">.+)") + "$", RegexOptions.IgnoreCase);
            var match = regex.Match(requestUrl);
            var groups = match.Groups;
            var requestParameters = regex.GetGroupNames()
                .Skip(1)
                .Select(x => new { Key = x, groups[x].Value })
                .Where(x => !string.IsNullOrEmpty(x.Value))
                .ToDictionary(x => x.Key, x => x.Value);
            if (match.Success)
            {
                var parameters = context.Get<Dictionary<string, string>>(RequestParams) ?? new Dictionary<string, string>();
                requestParameters.ToList().ForEach(x => parameters.Add(x.Key, x.Value));
                context.Set(RequestParams, parameters);
            }
            return match.Success;
        }
    }
}
