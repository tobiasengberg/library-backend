using Microsoft.AspNetCore.Mvc;

namespace library_api.Controllers;

public class BookController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}