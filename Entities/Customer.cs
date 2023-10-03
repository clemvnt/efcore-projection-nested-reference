namespace EFCore.ProjectionOnNestedReference.Entities;

public class Customer
{
    public string Id { get; set; } = string.Empty;

    public string? CompanyId { get; set; }

    public Company? Company { get; set; }
}
