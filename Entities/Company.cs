namespace EFCore.ProjectionOnNestedReference.Entities;

public class Company
{
    public string Id { get; set; } = string.Empty;

    public string CompanyName { get; set; } = string.Empty;

    public string? CountryId { get; set; }

    public Country? Country { get; set; }
}
