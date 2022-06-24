using Microsoft.AspNetCore.Mvc;
using StonesNatureTnWeb.Data;
using StonesNatureTnWeb.Models;
using System.Diagnostics;

namespace StonesNatureTnWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
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

        //public PartialViewResult Navbar()
        //{
        //    ViewData["Categories"] = _db.Categories.ToList();
        //    ViewData["Products"] = _db.Products.ToList();
        //    return PartialView("~/Views/Shared/_NavbarPartialView.cshtml");
        //}
    }
}