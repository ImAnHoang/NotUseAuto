using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NotUseAuto.Data;

using NotUseAuto.Models;
using System.Linq;


namespace NotUseAuto.Controllers
{
    [Authorize]
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext context;
        public ProductsController(ApplicationDbContext dbContext)
        {
            context = dbContext;
            
        }
        [Route("/")]
        public IActionResult Index()
        {
            var products = context.Product.ToList();
            var categories = context.Category.ToList();
            ViewBag.Categories = categories;
            return View(products);
        }
        
        [HttpGet]
        
        public IActionResult Create()
        {
            var categories = context.Category.ToList();
            ViewBag.Categories = categories;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                context.Product.Add(product);
                context.SaveChanges();
                return Redirect("/");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Details(int? id)
        {
            var products = context.Product.ToList();
            var item =  products.Find(p => p.Id == id);
            return View(item);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var products = context.Product.ToList();
            var item = products.Find(p => p.Id == id);
            var categories = context.Category.ToList();
            ViewBag.Categories = categories;
            return View(item);
        }
        [HttpPost]
        public IActionResult Update(Product product)
        {
            if (ModelState.IsValid)
            {
                context.Product.Update(product);
                context.SaveChanges();
                return Redirect("/");

            }
            return View();
        }
        [HttpGet]
        public IActionResult Confirm(int? id)
        {
            var products = context.Product.ToList();
            var item = products.Find(p => p.Id == id);
            return View(item);
        }
        [HttpPost]
        public IActionResult Delete(Product product)
        {
            context.Product.Remove(product);
            context.SaveChanges();
            return Redirect("/");
        }
    }
    
    
}
