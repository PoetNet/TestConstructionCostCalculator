namespace Domain.Entities;

public class Building
{
    public Building(
        double width,
        double length,
        double height,
        BuildingType buildingType,
        RoofType roofType,
        List<AdditionalService> additionalServices,
        int gatesCount,
        int windowsCount)
    {
        Width = width;
        Length = length;
        Height = height;
        BuildingType = buildingType;
        RoofType = roofType;
        AdditionalServices = additionalServices;
        GatesCount = gatesCount;
        WindowsCount = windowsCount;
    }

    public Guid Id { get; set; }
    public double Width { get; set; }
    public double Length { get; set; }
    public double Height { get; set; }

    public BuildingType BuildingType { get; set; }
    public RoofType RoofType { get; set; }
    public List<AdditionalService> AdditionalServices { get; set; } = new();


    public int GatesCount { get; set; }
    public int WindowsCount { get; set; }
}
