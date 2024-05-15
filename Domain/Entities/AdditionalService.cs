namespace Domain.Entities;

public class AdditionalService
{
    public AdditionalService(string title)
    {
        Title = title;
    }

    Guid Id { get; set; }
    public string Title { get; set; }
}
