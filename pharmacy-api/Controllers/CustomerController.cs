using Microsoft.AspNetCore.Mvc;
using pharmacy_api.Model.Entities;
using pharmacy_api.Services.Interfaces;

namespace pharmacy_api.Controllers
{
  [ApiController]
  [Route( "api/Customer" )]
  public class CustomerController : ControllerBase
  {
    private readonly ICustomerService _service;

    public CustomerController( ICustomerService service )
    {
      _service = service;
    }

    [HttpGet("/GetAll")]
    public async Task<IActionResult> GetAllAsync( )
    {
      return StatusCode( StatusCodes.Status200OK, await _service.GetAllCustomersAsync() );
    }

    [HttpGet("/Get")]
    public async Task<IActionResult> GetAsync( int customerId )
    {
      return StatusCode( StatusCodes.Status200OK, await _service.GetCustomerAsync( customerId ) );
    }

    [HttpPost("/Create")]
    public async Task<IActionResult> CreateAsync( Customer customer )
    {
      return StatusCode( StatusCodes.Status200OK, await _service.CreateCustomerAsync( customer ) );
    }

    [HttpPut("/Update")]
    public async Task<IActionResult> UpdateAsync( Customer customer )
    {
      return StatusCode( StatusCodes.Status200OK, await _service.UpdateCustomerAsync( customer ) );
    }

    [HttpDelete("/Delete")]
    public async Task<IActionResult> DeleteAsync( int customerId )
    {
      return StatusCode( StatusCodes.Status200OK, await _service.DeleteCustomerAsync( customerId ) );
    }
  }
}
