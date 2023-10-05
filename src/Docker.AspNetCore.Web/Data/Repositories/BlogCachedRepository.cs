using Docker.AspNetCore.Web.Data.Models;
using Docker.AspNetCore.Web.Data.Repositories.Interfaces;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;

namespace Docker.AspNetCore.Web.Data.Repositories;

public class BlogCachedRepository : IBlogRepository
{
    private readonly BlogRepository _blogRepository;
    private readonly IDistributedCache _redisCache;

    public BlogCachedRepository(
        BlogRepository blogRepository,
        IDistributedCache redisCache)
    {
        _blogRepository = blogRepository;
        _redisCache = redisCache;
    }

    public IEnumerable<Blog> GetBlogPosts()
    {
        var blogPostsString = _redisCache.GetString("blogPosts");

        if (blogPostsString is not null)
        {
            return JsonConvert.DeserializeObject<IEnumerable<Blog>>(blogPostsString);
        }

        var blogPosts = _blogRepository.GetBlogPosts();

        _redisCache.SetString("blogPosts", JsonConvert.SerializeObject(blogPosts));

        return blogPosts;
    }
}
