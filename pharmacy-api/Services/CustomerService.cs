using pharmacy_api.Database.Interfaces;
using pharmacy_api.Model.Entities;
using pharmacy_api.Services.Interfaces;

namespace pharmacy_api.Services
{
  public class CustomerService : ICustomerService
  {
    private readonly ICustomerRepository _repository;

    public CustomerService( ICustomerRepository repository )
    {
      _repository = repository;
    }

    public async Task<Customer?> GetCustomerAsync( int customerId )
    {
      return await _repository.GetCustomerAsync( customerId );
    }

    public async Task<List<Customer>> GetAllCustomersAsync( )
    {
      return await _repository.GetAllCustomersAsync();
    }

    public async Task<Customer?> CreateCustomerAsync( Customer customer )
    {
      return await _repository.CreateCustomerAsync( customer );
    }

    public async Task<Customer?> UpdateCustomerAsync( Customer customer )
    {
      return await _repository.UpdateCustomerAsync( customer );
    }

    public async Task<Customer?> DeleteCustomerAsync( int customerId )
    {
      return await _repository.DeleteCustomerAsync( customerId );
    }
  }
}
