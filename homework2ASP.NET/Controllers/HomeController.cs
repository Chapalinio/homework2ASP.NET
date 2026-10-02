using Microsoft.AspNetCore.Mvc;

namespace homework2ASP.NET.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult About() => View();
    }
}
