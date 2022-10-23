using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NotUseAuto.Data;
using NotUseAuto.Models;
using System.Data;
using System.Linq;

namespace NotUseAuto.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext context;
        public AdminController(ApplicationDbContext dbContext)
        {
            context = dbContext;

        }
        public IActionResult Index()
        {
            var categories = context.WaitCategory.ToList();
            return View(categories);
        }
        public IActionResult Approve(int? id)
        {
            var categories = context.WaitCategory.ToList();
            var item = categories.Find(p => p.Id == id);
            context.WaitCategory.Remove(item);
            var new_item = new Category
            {
                Name = item.Name,
                Description = item.Description
            };
            context.Category.Add(new_item);
            context.SaveChanges();
            return Redirect("/Admin");
        }
        public IActionResult Reject(int? id)
        {
            var categories = context.WaitCategory.ToList();
            var item = categories.Find(p => p.Id == id);
            context.WaitCategory.Remove(item);
            context.SaveChanges();
            return Redirect("/Admin");
        }
    }
}
