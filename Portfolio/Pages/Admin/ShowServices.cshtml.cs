using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Data;
using Portfolio.Models;

namespace Portfolio.Pages.Admin
{
    public class ShowServicesModel : PageModel
    {
        DataDbContext db;
        public List<Services> Services { get; set; }

       
        public ShowServicesModel(DataDbContext _db)
        {
            db = _db;
        }

        public void OnGet()
        {
            Services=db.Services.ToList();

        }
    }
}
