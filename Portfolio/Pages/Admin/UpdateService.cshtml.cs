using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Data;
using Portfolio.Models;

namespace Portfolio.Pages.Admin
{
    public class UpdateServiceModel : PageModel
    {
        DataDbContext db;
        public Services Services { get; set; }


        public UpdateServiceModel(DataDbContext _db)
        {
            db = _db;
        }

        public void OnGet(int id)
        {

			Services = db.Services.Where(s => s.Id == id).FirstOrDefault();

		}
        [HttpPost]
        public IActionResult OnPost(Services services)
        {
            db.Services.Update(services);
            db.SaveChanges();
            return RedirectToPage("ShowServices");
        }
    }
}
