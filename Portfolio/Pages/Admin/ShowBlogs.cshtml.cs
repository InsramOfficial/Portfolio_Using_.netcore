using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Data;
using Portfolio.Models;

namespace Portfolio.Pages.Admin
{
    public class ShowBlogsModel : PageModel
    {
        DataDbContext db;
        public List<Blogs> Blogs { get; set; }

        public ShowBlogsModel(DataDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            Blogs = db.Blogs.ToList();
            

        }
    }
}
