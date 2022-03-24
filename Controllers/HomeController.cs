using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using YogaShastraTeacherCourseApp.Models;

namespace YogaShastraTeacherCourseApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext _dbContext;
        public HomeController(ILogger<HomeController> logger,
            ApplicationDbContext DB)
        {
            _logger = logger;
            _dbContext = DB;
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