using EFCore.ProjectionOnNestedReference;
using EFCore.ProjectionOnNestedReference.Data;

using Context context = new();

await context.Database.EnsureCreatedAsync();

try
{
    _ = context.Customers
        .Select(m => new CustomerDto()
        {
            Id = m.Id,
            CompanyId = m.CompanyId,
            Company = m.Company != null ? new CompanyDto()
            {
                Id = m.Company.Id,
                CompanyName = m.Company.CompanyName,
                CountryId = m.Company.CountryId,
                Country = new CountryDto()
                {
                    Id = m.Company.Country.Id,
                    CountryName = m.Company.Country.CountryName,
                },
            } : null,
        })
        //.Where(m => m.Company!.CompanyName == "COMPANY") // It works
        .Where(m => m.Company!.Country!.CountryName == "COUNTRY") // It fails
        .ToArray();

    Console.WriteLine("It works");
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}

