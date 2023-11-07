using Bulky.Data;
using Bulky.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bulky.Pages
{
    public class AddCategoryModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public Category Category { get; set; }
        public AddCategoryModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            
            _db.Categories.Add(Category);
            _db.SaveChanges();
            TempData["success"] = "A new category has been added";
            return RedirectToPage("Categories");
            
        }
    }
}
