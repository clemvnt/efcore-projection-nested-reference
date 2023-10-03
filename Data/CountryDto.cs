namespace EFCore.ProjectionOnNestedReference.Data;

public class CountryDto : ICountryDto
{
    public string Id { get; set; } = string.Empty;

    public string CountryName { get; set; } = string.Empty;
}
