using Crudapplication.Data;
using Crudapplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Crudapplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyDbContext conn;
        public HomeController()
        {
            conn = new MyDbContext();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Student ad)
        {
            var data = conn.Students.Where(u => u.studentemail == ad.studentemail && u.studentpassword == ad.studentpassword).FirstOrDefault();

            if (data == null)
            {
                return Unauthorized("Enter Correct Studentemail or password");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
