using NotUseAuto.Models;
using NotUseAuto.Data;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

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
    }
}
