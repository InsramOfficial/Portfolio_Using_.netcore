using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Data;
using Portfolio.Models;
using System.ComponentModel;

namespace Portfolio.Pages.Admin
{
    public class ShowServicesModel : PageModel
    {
        DataDbContext db;
        public List<Services> Services { get; set; }
        public Services services { get; set; }
       
        public ShowServicesModel(DataDbContext _db)
        {
            db = _db;
        }

        public void OnGet()
        {
            Services=db.Services.ToList();

        }

 
        public IActionResult OnGetDelete(int id)
        {
            var record = db.Services.Find(id);
            db.Services.Remove(record);
            db.SaveChanges();
            return RedirectToPage("ShowServices");
        }
    }
}
