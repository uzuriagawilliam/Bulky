using Bulky.Data;
using Bulky.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bulky.Pages
{
    [BindProperties]
    public class DeleteCategoryModel : PageModel
    {
        
        private readonly ApplicationDbContext _db;
        public Category Category { get; set; }
        public DeleteCategoryModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(Guid Id)
        {
            if (Id != null)
            {
                Category = _db.Categories.FirstOrDefault(c => c.Id == Id);
            }
        }

        public IActionResult OnPost()
        {
            _db.Categories.Remove(Category);
            _db.SaveChanges();
            TempData["success"] = "A category has been removed";
            return RedirectToPage("Categories");
        }
    }
}
