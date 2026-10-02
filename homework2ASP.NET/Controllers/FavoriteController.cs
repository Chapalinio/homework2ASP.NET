using Microsoft.AspNetCore.Mvc;

namespace homework2ASP.NET.Controllers
{
    public class FavoriteController : Controller
    {
        public IActionResult Games() => View();
        public IActionResult Movies() => View();
        public IActionResult Music() => View();
    }
}
