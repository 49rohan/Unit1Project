using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Unit1Project.Models;

namespace Unit1Project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
