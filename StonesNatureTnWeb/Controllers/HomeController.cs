using Microsoft.AspNetCore.Mvc;
using StonesNatureTnWeb.Data;
using StonesNatureTnWeb.Models;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;

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
            ViewData["Categories"] = _db.Categories.ToList();
            ViewData["Products"] = _db.Products.ToList();
            ViewData["CurrentRoute"] = "Home";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Gallery()
        {
            ViewData["CurrentRoute"] = "Gallery";
            return View();
        }

        public IActionResult About()
        {
            ViewData["CurrentRoute"] = "About";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["CurrentRoute"] = "Contact";
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

        public IActionResult ContactSendEmail(string name, string email, string message)
        {
            var mailMessage = new MailMessage();

            var smtpClient = new SmtpClient("mail.stonesnaturetn.com",25);

            mailMessage.From = new MailAddress("contact@stonesnaturetn.com");
            mailMessage.To.Add("info@stonesnaturetn.com");
            //mailMessage.To.Add("harmonitechnology@gmail.com");

            mailMessage.Subject = $"{name} | Mesaj ";

            mailMessage.Body = $"<h2>Email:{email}</h2><h4>Mesaj:{message}</h5>";
            mailMessage.IsBodyHtml = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Port = 587;
            smtpClient.Credentials = new NetworkCredential("contact@stonesnaturetn.com", "StonesNature089!");
            //smtpClient.UseDefaultCredentials = true;

            smtpClient.Send(mailMessage);

            return RedirectToAction("Index");
        }
    }
}