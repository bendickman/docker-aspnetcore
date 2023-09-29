using Docker.AspNetCore.Web.Data;
using Docker.AspNetCore.Web.Data.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Docker.AspNetCore.Web.Pages;
public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly ApplicationDbContext _context;
    public IEnumerable<Branch> Branches;

    public IndexModel(
        ILogger<IndexModel> logger,
        ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public void OnGet()
    {
        Branches = _context.Branches.ToList();
    }
}
