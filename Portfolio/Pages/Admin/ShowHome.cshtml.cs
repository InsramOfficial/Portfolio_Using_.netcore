using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Data;
using Portfolio.Models;

namespace Portfolio.Pages.Admin
{
    public class ShowHomeModel : PageModel
    {
        DataDbContext db;
        public Home Home { get; set; }

        
        public ShowHomeModel(DataDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            Home = db.home.FirstOrDefault();
        }

        [HttpPost]
        public IActionResult OnPost(Home home)
        {
            db.home.Update(home);
            db.SaveChanges();
            return RedirectToPage("ShowHome");
        }
    }
}
