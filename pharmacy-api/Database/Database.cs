using Microsoft.EntityFrameworkCore;
using pharmacy_api.Database.Interfaces;
using pharmacy_api.Model.Entities;

namespace pharmacy_api.Database
{
  public class Database(DbContextOptions options) : DbContext(options), IDatabase
  {
    public DbSet<Customer> Customer { get; set; }

    public async Task<bool> SaveAsync()
    {
      return await SaveChangesAsync() > 0;
    }
  }
}
