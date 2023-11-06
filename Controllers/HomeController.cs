using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shopping_Cart.Models;
using System.Diagnostics;

namespace Shopping_Cart.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ShoppingCartContext _context;

        public HomeController(ILogger<HomeController> logger, ShoppingCartContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.category = _context.Products.ToList();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
        {
            ViewBag.category = _context.Products.ToList();
            return View();
        }
        public IActionResult Contact()
        {
            ViewBag.category = _context.Products.ToList();
            return View();
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Pdetails(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
      public IActionResult Shirts()
        {
            ViewBag.category = _context.Products.ToList();

            return View();
        }
       public IActionResult Jackets()
        {
            ViewBag.category = _context.Products.ToList();
            return View();
        }
        public IActionResult Jeans()
        {
            ViewBag.category = _context.Products.ToList();
            return View();
        }
        public IActionResult Jewellery()
        {
            ViewBag.category = _context.Products.ToList();
            return View();
        }
       
    }
}