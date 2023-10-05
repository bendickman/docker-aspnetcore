using Docker.AspNetCore.Web.Data.Models;
using Docker.AspNetCore.Web.Data.Repositories.Interfaces;

namespace Docker.AspNetCore.Web.Data.Repositories;

public class BlogRepository : IBlogRepository
{
    private readonly ApplicationDbContext _applicationDbContext;

    public BlogRepository(
        ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }

    public IEnumerable<Blog> GetBlogPosts()
    {
        return _applicationDbContext.BlogPosts;
    }
}
