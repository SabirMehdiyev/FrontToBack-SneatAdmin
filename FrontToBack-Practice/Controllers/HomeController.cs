using Microsoft.AspNetCore.Mvc;

namespace FrontToBack_Practice.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
