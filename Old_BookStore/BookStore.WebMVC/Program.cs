using BookStore.Persistence;
using Microsoft.EntityFrameworkCore;
using BookStore.Domain.Entities;

namespace BookStore.WebMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            string connection = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<BookStoreDbContext>(options => options.UseSqlServer(connection));

            var app = builder.Build();

            app.UseDefaultFiles();
            app.UseStaticFiles();

            /*using (BookStoreDbContext db = new
                (new DbContextOptionsBuilder<BookStoreDbContext>()
                    .UseSqlServer(connection).Options))
            {
                db.Users.Add(new ApplicationUser()
                {
                    Password = "blaster123",
                    Email = "pozikosuaru2956@gmail.com",
                    MemberSince = DateTime.Now,
                    FirstName = "Kostya",
                    LastName = "Byliuk",
                    IsActive = true,
                    Balance = 100,
                    Country = "Ukraine",
                    City = "Kyiv",
                    AddressLine1 = "someAddress1",
                    AddressLine2 = "someAddress2"
                });
                db.SaveChanges();
            }*/

            app.MapGet("/", (BookStoreDbContext db) => db.Users.ToList());

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}