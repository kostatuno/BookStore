using System.Text;

namespace BookStore.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");
            app.Run(async (context) =>
            {
                context.Response.ContentType = "text/html; charset=utf-8";
                await context.Response.SendFileAsync("html/index.html");
            });
            app.Run();
        }

        public record Person(string Name, int Age);
    }
}