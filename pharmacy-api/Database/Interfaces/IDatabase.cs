using Microsoft.EntityFrameworkCore;
using pharmacy_api.Model.Entities;

namespace pharmacy_api.Database.Interfaces
{
  public interface IDatabase
  {
    DbSet<Customer> Customer { get; set; }
    Task<bool> SaveAsync();
  }
}
