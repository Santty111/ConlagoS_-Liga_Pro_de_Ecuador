using System.Diagnostics;
using ConlagoS__Liga_Pro_de_Ecuador.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConlagoS__Liga_Pro_de_Ecuador.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
