using NotUseAuto.Models;
using NotUseAuto.Data;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace NotUseAuto.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext context;
        public CustomerController(ApplicationDbContext dbContext)
        {
            context = dbContext;

        }
        public IActionResult Index()
        {
            var products = context.Product.ToList();
            var categories = context.Category.ToList();
            ViewBag.Categories = categories;
            return View(products);
        }
        public IActionResult Index2(int? id)
        {
            var products = context.Product.ToList();
            var categories = context.Category.ToList();
            ViewBag.Categories = categories;
            var productSearch = context.Category.Include(c => c.Products).FirstOrDefault(c => c.Id == id);

            return View(productSearch);
        }
    }
}
