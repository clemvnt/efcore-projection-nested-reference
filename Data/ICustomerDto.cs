namespace EFCore.ProjectionOnNestedReference.Data
{
    public interface ICustomerDto
    {
        string Id { get; set; }

        string? CompanyId { get; set; }

        ICompanyDto? Company { get; set; }
    }
}