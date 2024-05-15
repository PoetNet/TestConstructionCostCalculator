using Domain.Structs;

namespace Domain.Entities;

public class Color
{
    public Color(string title)
    {
        Title = title;
    }

    public Guid Id { get; set; }
    public string Title { get; set; }
    public RGB RGB { get; set; }
    public string? PathToCover { get; set; }
}
