using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Api.Benchmark.AspNetCore.Http
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Map("/ping", builder =>
            {
                builder.Run(context =>
                {
                    return context.Response.WriteAsync("Pong!");
                });
            });
        }
    }
}