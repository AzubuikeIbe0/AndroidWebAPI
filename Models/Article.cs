using System;
using System.Collections.Generic;

namespace AndroidWebAPI.Models;

public partial class Article
{
    public string Id { get; set; } = null!;

    public string? Title { get; set; }

    public string? Subtitle { get; set; }

    public string? Body { get; set; }

    public string? Author { get; set; }

    public string? AuthorImageUrl { get; set; }

    public string? Category { get; set; }

    public string? ImageUrl { get; set; }

    public int? Views { get; set; }

    public DateTime? CreatedAt { get; set; }
}
