using Microsoft.AspNetCore.Mvc;
using StonesNatureTnWeb.Data;
using StonesNatureTnWeb.Models;

namespace StonesNatureTnWeb.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ProductController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index(int productId)
        {
            ViewData["Product"] = _db.Products.Find(productId);
            ViewData["ProductImages"] = _db.ProductImages.Where(p => p.ProductId == productId).ToList();
            ViewData["ProductDetails"] = _db.ProductDetail.Where(p => p.ProductId == productId).ToList();
            ViewData["ProductSizes"] = _db.ProductSize.Where(p => p.ProductId == productId).ToList();
            return View();
        }
    }
}
