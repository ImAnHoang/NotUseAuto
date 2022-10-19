using Microsoft.AspNetCore.Mvc;
using NotUseAuto.Data;
using NotUseAuto.Models;
using System.Linq;

namespace NotUseAuto.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext context;
        public CategoryController(ApplicationDbContext dbContext)
        {
            context = dbContext;

        }
        public IActionResult Index()
        {
            var categories = context.Category.ToList();
            return View(categories);
    
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(WaitCategory category)
        {
            if (ModelState.IsValid)
            {
                context.WaitCategory.Add(category);
                context.SaveChanges();
                return Redirect("/Category");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            var categories = context.Category.ToList();
            var item = categories.Find(p => p.Id == id);
            return View(item);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var categories = context.Category.ToList();
            var item = categories.Find(p => p.Id == id);
            return View(item);
        }
        [HttpPost]
        public IActionResult Update(Category category)
        {
            if (ModelState.IsValid)
            {
                context.Category.Update(category);
                context.SaveChanges();
                return Redirect("/Category");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Confirm(int? id)
        {
            var categories = context.Category.ToList();
            var item = categories.Find(p => p.Id == id);
            return View(item);
        }
        [HttpPost]
        public IActionResult Delete(Category category)
        {
            context.Category.Remove(category);
            context.SaveChanges();
            return Redirect("/Category");
        }

    }
}
