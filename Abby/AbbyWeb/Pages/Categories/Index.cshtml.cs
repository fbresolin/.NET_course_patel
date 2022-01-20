using AbbyWeb.Data;
using AbbyWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbyWeb.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDBContext _db;
        public IEnumerable<Category> Categories { get; set;}

        public IndexModel(ApplicationDBContext db)
        {
            _db = db;
        }
        // OnGet is a special method and is automatically called on loading the present page
        public void OnGet()
        {
            Categories = _db.Categories;
        }
    }
}
