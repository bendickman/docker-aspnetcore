using Docker.AspNetCore.Web.Data.Models;

namespace Docker.AspNetCore.Web.Data.Repositories.Interfaces;

public interface IBlogRepository
{
    IEnumerable<Blog> GetBlogPosts();
}
