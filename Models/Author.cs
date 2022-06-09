namespace Models;

public class Author
{
    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public AuthorLinks Links { get; set; } = new();

    public Uri? Image { get; set; }
}
