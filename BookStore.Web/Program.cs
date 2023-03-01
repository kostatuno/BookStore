namespace BookStore.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");

            app.RunAsync();
            //app.StartAsync();
            Task.Delay(1000);
            app.StopAsync();
        }
    }
}