using Bulky.Data;
using Bulky.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bulky.Pages
{
    public class CategoriesModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public List<Category> CatList { get; set; }
        public CategoriesModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            CatList = _db.Categories.ToList();
        }
    }
}
