using Microsoft.AspNetCore.Mvc;

namespace CP2_.NET.Controllers;

public class UserController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}