using Microsoft.AspNetCore.Mvc;

namespace FrontToBack_Practice.Controllers;

public class LayoutsController : Controller
{
    public IActionResult Container()
    {
        return View();
    }
    public IActionResult Blank()
    {
        return View();
    }
    public IActionResult Fluid()
    {
        return View();
    }
    public IActionResult WithoutMenu()
    {
        return View();
    }
    public IActionResult WithoutNav()
    {
        return View();
    }
}
