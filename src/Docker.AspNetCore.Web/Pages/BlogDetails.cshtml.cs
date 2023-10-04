using Docker.AspNetCore.Web.Data;
using Docker.AspNetCore.Web.Data.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Docker.AspNetCore.Web.Pages
{
    public class BlogDetailsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public Blog? BlogPost { get; set; }

        public BlogDetailsModel(
            ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet(
            int id)
        {
            BlogPost = _context
                .BlogPosts
                .FirstOrDefault(p => p.Id == id);
        }
    }
}
