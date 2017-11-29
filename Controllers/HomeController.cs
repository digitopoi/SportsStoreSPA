using Microsoft.AspNetCore.Mvc;
using SportsStoreSPA.Models;
using System.Linq;

namespace SportsStoreSPA.Controllers
{
    public class HomeController : Controller
    {
        private DataContext _context;

        public HomeController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.Message = "Sports Store App";
            return View(_context.Products.First());
        }
    }
}
