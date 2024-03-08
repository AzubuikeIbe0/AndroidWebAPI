using System;
using System.Collections.Generic;

namespace AndroidWebAPI.Models;

public partial class Author
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? ImageUrl { get; set; }

    public virtual ICollection<Article> Articles { get; set; } = new List<Article>();
}
