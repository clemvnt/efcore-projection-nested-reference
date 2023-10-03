namespace EFCore.ProjectionOnNestedReference.Data
{
    public interface ICompanyDto
    {
        string Id { get; set; }

        string CompanyName { get; set; }

        string? CountryId { get; set; }

        CountryDto? Country { get; set; }
    }
}