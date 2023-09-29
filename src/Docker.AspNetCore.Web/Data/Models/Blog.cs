namespace Docker.AspNetCore.Web.Data.Models;

public class Blog
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;
}
