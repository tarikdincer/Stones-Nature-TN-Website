using Microsoft.AspNetCore.Mvc;
using StonesNatureTnWeb.Data;

namespace StonesNatureTnWeb.ViewComponents
{
    public class NavbarViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _db;
        public NavbarViewComponent(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewData["Categories"] = _db.Categories.ToList();
            ViewData["Products"] = _db.Products.ToList();
            return View("~/Views/Home/Components/Navbar/Default.cshtml");
        }
    }
}
