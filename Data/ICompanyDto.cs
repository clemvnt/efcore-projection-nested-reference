namespace EFCore.ProjectionOnNestedReference.Data
{
    public interface ICompanyDto
    {
        string Id { get; set; }

        string CompanyName { get; set; }

        string? CountryId { get; set; }

        ICountryDto? Country { get; set; }
    }
}