using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Data;
using Portfolio.Models;

namespace Portfolio.Pages.Admin
{
    public class AddServicesModel : PageModel
    {
        DataDbContext db;
        public Services Services { get; set; }

        public AddServicesModel(DataDbContext _db)
        {
            db = _db;
        }

        [HttpPost]
        public IActionResult OnPost(Services services)
        {
            Services service = new();
            service.Title= services.Title;
            service.Description= services.Description;
            service.Icon= services.Icon;

            db.Services.Add(service);
            db.SaveChanges();

            return RedirectToPage("AddServices");
        }
    }
}
