using AbbyWeb.Data;
using AbbyWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbyWeb.Pages.Categories
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDBContext _db;
        public Category Categories { get; set; }
        public DeleteModel(ApplicationDBContext db)
        {
            _db = db;
        }
        public void OnGet(int Id)
        {
            Categories = _db.Categories.Find(Id);
        }
        public async Task<IActionResult> OnPost()
        {
            var categoryFromDb = _db.Categories.Find(Categories.Id);
            if (categoryFromDb != null)
            {
                _db.Categories.Remove(categoryFromDb);
                await _db.SaveChangesAsync();
                TempData["success"] = "Category deleted successfully";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
