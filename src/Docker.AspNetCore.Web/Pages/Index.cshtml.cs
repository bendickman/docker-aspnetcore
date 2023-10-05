using Docker.AspNetCore.Web.Data.Models;
using Docker.AspNetCore.Web.Data.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Docker.AspNetCore.Web.Pages;
public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IBlogRepository _blogRepository;
    public IEnumerable<Blog> BlogPosts;

    public IndexModel(
        ILogger<IndexModel> logger,
        IBlogRepository blogRepository)
    {
        _logger = logger;
        _blogRepository = blogRepository;
    }

    public void OnGet()
    {
        _logger.LogInformation("Test log from Index code-behind");
        BlogPosts = _blogRepository.GetBlogPosts();
    }
}
