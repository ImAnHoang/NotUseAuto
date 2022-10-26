using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NotUseAuto.Data;
using NotUseAuto.Models;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace NotUseAuto.Controllers
{

    [Authorize(Roles = "Administrator")]
    public class ProductsController : Controller
    {
        
        private readonly ApplicationDbContext context;
        
        
        public ProductsController(ApplicationDbContext dbContext)
        {
            context = dbContext; 

        }
        protected UserManager<ApplicationUser> UserManager { get; set; }
        [Route("/admin")]
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
                return Redirect("/admin");
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
                return Redirect("/admin");

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
            return Redirect("/admin");
        }
        public   IActionResult UserView()
        {
            var claimIdentity = (ClaimsIdentity)User.Identity;
            
            var claims = claimIdentity.FindFirst(ClaimTypes.NameIdentifier);
            string currentUserId = claims.Value;
            ApplicationUser currentUser = (ApplicationUser)context.Users.FirstOrDefault(x => x.Id == currentUserId);
            
            ViewBag.Img = currentUser.Image;
            ViewBag.Id = currentUser.Id;
            ViewBag.Email = currentUser.Email;
            ViewBag.UserName = currentUser.UserName;
            ViewBag.Fullname = currentUser.FullName;
            ViewBag.Address = currentUser.Address;
            ViewBag.Dob = currentUser.DoB;
            return View(currentUser);
        }
        [HttpPost]
        public IActionResult Search(string search)
        {
            var products = context.Product.Where(p => p.Name.Contains(search)).ToList();
            var categories = context.Category.ToList();
            ViewBag.Categories = categories;
            TempData["search"] = search;

            return View("Index", products);
        }
        public IActionResult SortDESC()
        {
            var products = context.Product.OrderByDescending(p => p.Quantity).ToList();
            var categories = context.Category.ToList();
            ViewBag.Categories = categories;
            return View("Index", products);
        }
        public IActionResult SortASC()
        {
            var products = context.Product.OrderBy(p => p.Quantity).ToList();
            var categories = context.Category.ToList();
            ViewBag.Categories = categories;
            return View("Index", products);
        }
    }
    
    
}
