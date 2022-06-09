namespace Models;

public class BlogPost
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;

    public string Content { get; set; } = string.Empty;

    public Status Status { get; set; }

    public DateTime? PublishDate { get; set; }

    public DateTime? LastEdited { get; set; }

    public Author Author { get; set; } = new();

    public string[] Topics { get; set; } = Array.Empty<string>();
}
