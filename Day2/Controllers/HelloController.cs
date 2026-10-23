using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Day2.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numtimes = 5)
        {
            ViewData["Message"] = "Hello" + name;
            ViewBag.NumTimes = numtimes;
            return View();

        }
    }
}
