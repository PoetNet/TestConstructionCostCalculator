namespace Domain.Entities;

public class BuildingType
{
    public BuildingType(
        string title, 
        bool hasGates, 
        bool hasWindows)
    {
        Title = title;
        HasGates = hasGates;
        HasWindows = hasWindows;
    }

    Guid Id { get; set; }
    public string Title { get; set; }
    public bool HasGates { get; set; }
    public bool HasWindows { get; set; }
}
