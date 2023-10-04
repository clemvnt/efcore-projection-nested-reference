namespace EFCore.ProjectionOnNestedReference.Data;

public class CompanyDto : ICompanyDto
{
    public string Id { get; set; } = string.Empty;

    public string CompanyName { get; set; } = string.Empty;

    public string? CountryId { get; set; }

    public ICountryDto? Country { get; set; }
}
