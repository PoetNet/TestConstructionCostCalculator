namespace Domain.Entities;

public class RoofType
{
    public RoofType(string title)
    {
        Title = title;
    }

    public Guid Id { get; set; }
    public string Title { get; set; } 
}
