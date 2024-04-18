using Microsoft.EntityFrameworkCore.Metadata.Builders;
using pharmacy_api.Model.Entities;

namespace pharmacy_api.Database.Configuration
{
  public class CustomerConfiguration
  {
    public CustomerConfiguration(EntityTypeBuilder<Customer> entityBuilder)
    {
      entityBuilder.HasKey(x => x.CustomerId);
      entityBuilder.Property(x => x.FullName).IsRequired();
      entityBuilder.Property(x => x.BirthDate).IsRequired();
      entityBuilder.Property(x => x.Age);
    }
  }
}
