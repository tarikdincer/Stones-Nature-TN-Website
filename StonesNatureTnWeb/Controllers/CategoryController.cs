using Microsoft.AspNetCore.Mvc;
using StonesNatureTnWeb.Data;
using StonesNatureTnWeb.Models;

namespace StonesNatureTnWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index(int categoryId)
        {
            ViewData["Category"] = _db.Categories.Find(categoryId);
            ViewData["Products"] = _db.Products.Where(p => p.CategoryId == categoryId).ToList();
            return View();
        }
    }
}
