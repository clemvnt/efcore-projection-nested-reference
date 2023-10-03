namespace EFCore.ProjectionOnNestedReference.Data;

public class CustomerDto : ICustomerDto
{
    public string Id { get; set; } = string.Empty;

    public string? CompanyId { get; set; }

    public CompanyDto? Company { get; set; }
}
