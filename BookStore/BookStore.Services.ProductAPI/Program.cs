using AutoMapper;
using BookStore.Services.ProductAPI.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Services.ProductAPI
{
    public interface ICounter
    {
        int Value { get; }
    }
    
    public class RandomCounter : ICounter
    {
        static Random random = new Random();
        private int _value;
        public RandomCounter()
        {
            _value = random.Next(0, 1000000);
        }
        public int Value
        {
            get
            {
                return _value;
            }
        }
    } 

    public class CounterService
    {
        public ICounter counter;
        public CounterService(ICounter counter)
        {
            this.counter = counter;
        }
    }

    public class CounterMiddleware
    {
        RequestDelegate next;
        int i = 0; // счетчик запросов
        public CounterMiddleware(RequestDelegate next)
        {
            this.next = next;
        }
        public async Task InvokeAsync(HttpContext httpContext, ICounter counter, CounterService counterService)
        {
            i++;
            httpContext.Response.ContentType = "text/html;charset=utf-8";
            await httpContext.Response.WriteAsync($"Запрос {i}; Counter: {counter.Value}; Service: {counterService.counter.Value}");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder();

            builder.Services.AddTransient<ICounter, RandomCounter>();
            builder.Services.AddTransient<CounterService>();
            var app = builder.Build();

            app.UseMiddleware<CounterMiddleware>();

            app.Run();
        }
        /*public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IBookRepository, BookRepository>();

            builder.Services.AddDbContext<ApplicationDbContext>(options => 
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();
            builder.Services.AddSingleton(mapper);
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }*/
    }
}