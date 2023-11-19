using FrontToBack.DAL;
using FrontToBack.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
        public IActionResult Detail(int id)
        {
            if (id <= 0) return BadRequest();

            NewProduct newproduct = _context.NewProducts.Include(np=>np.Category).FirstOrDefault(np => np.Id == id);
            
            if (newproduct is null) return NotFound();

            return View(newproduct);
        }
    }
}
