using FrontToBack.DAL;
using FrontToBack.Models;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Product> products = _context.Products.Include(p=>p.ProductImages).OrderByDescending(p => p.Order).Take(11).ToList();
            List<NewProduct> newProducts = _context.NewProducts.Include(p => p.ProductImages).ToList();

            HomeVM vm = new HomeVM
            {
                Products = products,
                NewProducts = newProducts
            };
            return View(vm);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
