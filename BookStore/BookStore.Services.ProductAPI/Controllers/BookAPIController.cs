using Microsoft.AspNetCore.Mvc;

namespace BookStore.Services.ProductAPI.Controllers
{
    public class BookAPIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
