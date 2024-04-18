using pharmacy_api.Model.Entities;

namespace pharmacy_api.Database.Interfaces
{
  public interface ICustomerRepository
  {
    Task<Customer?> GetCustomerAsync( int customerId );
    Task<List<Customer>> GetAllCustomersAsync( );
    Task<Customer?> CreateCustomerAsync( Customer customer );
    Task<Customer?> UpdateCustomerAsync( Customer customer );
    Task<Customer?> DeleteCustomerAsync( int customerId );
  }
}
