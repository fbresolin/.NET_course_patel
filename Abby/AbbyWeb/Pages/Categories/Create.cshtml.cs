using AbbyWeb.Data;
using AbbyWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbyWeb.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDBContext _db;
        public string CategoryName;
        public int DisplayOrder;
        public IEnumerable<Category> Categories { get; set; }
        public CreateModel(ApplicationDBContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostCreate(Category obj)
        {
            if (ModelState.IsValid)
            {
                await _db.Categories.AddAsync(obj);
                await _db.SaveChangesAsync();
            }
            return RedirectToPage("Index");
        }
    }
}
