using Microsoft.EntityFrameworkCore;
using pharmacy_api.Database.Interfaces;
using pharmacy_api.Model.Entities;

namespace pharmacy_api.Database.Repositories
{
  public class CustomerRepository : ICustomerRepository
  {
    private readonly IDatabase _database;

    public CustomerRepository( IDatabase database )
    {
      _database = database;
    }

    public async Task<Customer?> GetCustomerAsync( int customerId )
    {
      return await _database
        .Customer
        .FirstOrDefaultAsync( customer => customer.CustomerId.Equals( customerId ) );
    }

    public async Task<List<Customer>> GetAllCustomersAsync()
    {
      return await _database
        .Customer
        .ToListAsync();
    }

    public async Task<Customer?> CreateCustomerAsync( Customer customer )
    {
      await _database.Customer.AddAsync( customer );
      await _database.SaveAsync();
      return await _database
        .Customer
        .FirstOrDefaultAsync( cust => cust.CustomerId.Equals( customer.CustomerId ) );
    }

    public async Task<Customer?> UpdateCustomerAsync( Customer customer )
    {
      _database.Customer.Update( customer );
      await _database.SaveAsync();
      return await _database
        .Customer
        .FirstOrDefaultAsync(cust => cust.CustomerId.Equals( customer.CustomerId ) );
    }

    public async Task<Customer?> DeleteCustomerAsync(int customerId)
    {
      var customer = await GetCustomerAsync( customerId );
      _database.Customer.Remove(customer);
      await _database.SaveAsync();
      return customer;
    }
  }
}
