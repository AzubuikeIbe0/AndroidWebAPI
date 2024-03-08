using System;
using System.Collections.Generic;

namespace AndroidWebAPI.Models;

public partial class Article
{
    public string Id { get; set; } = null!;

    public string? Title { get; set; }

    public string? Subtitle { get; set; }

    public string? Body { get; set; }

    public string? Category { get; set; }

    public string? ImageUrl { get; set; }

    public int? Views { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? AuthorId { get; set; }

    public virtual Author? Author { get; set; }
}
