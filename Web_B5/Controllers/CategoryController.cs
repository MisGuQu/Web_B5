using Microsoft.AspNetCore.Mvc;
using Web_B5.Models;

namespace Web_B5.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Category> categories = _context.categories.ToList();
            return View(categories);
        }



        public IActionResult Create(string categoryName)
        {
            if (string.IsNullOrWhiteSpace(categoryName))
            {
                ModelState.AddModelError("categoryName", "Tên danh mục không được để trống.");
                return View("Create");
            }

            var category = new Category
            {
                CategoryName = categoryName
            };

            _context.categories.Add(category);
            _context.SaveChanges();

            return RedirectToAction("Index");

        }
    }
}
