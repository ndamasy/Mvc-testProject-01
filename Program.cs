using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Mvc_TestProject
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var WebApplicationBuilder = WebApplication.CreateBuilder();

            #region configer services

            WebApplicationBuilder.Services.AddControllersWithViews();

            #endregion

            #region conviger pip lines 
            var app = WebApplicationBuilder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!");
            //    });
            //});

            //app.MapGet("/", () => "Hello World 2"); // by default
            //app.MapGet("/{name}", async Context =>
            //{
            //    //var name = Context.Request.RouteValues["name"];
            //    await Context.Response.WriteAsync($"Hello {Context.Request.RouteValues["name"]}");
            //}); 
            //-----------------------------------------------
            //speific mvc route
            app.MapControllerRoute(
                name: "defult",
                pattern: "{controller=Movi}/{action=Index}/{id: regex(^\\d{{2}}?)}" //regex constrai
                //default:new { controller = "Movi", action = "Index" }
                );




            #endregion

            app.Run();


        }

        
    }
}
