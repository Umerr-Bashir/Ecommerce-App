using EcommerceApp.DTOs;
using EcommerceApp.DTOs.CustomerDTO;
using ECommerceApp.DTOs;
using ECommerceApp.DTOs.CustomerDTOs;
using ECommerceApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace ECommerceApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly CustomerService _customerService;
        // Injecting the services
        public CustomersController(CustomerService customerService)
        {
            _customerService = customerService;
        }
        
        
        // Retrieves customer details by ID.
        [HttpGet("GetCustomerById/{id}")]
        public async Task<ActionResult<ApiResponse<CustomerResponseDTO>>> GetCustomerById(int id)
        {
            var response = await _customerService.GetCustomerByIdAsync(id);
            if (response.StatusCode != 200)
            {
                return StatusCode((int)response.StatusCode, response);
            }
            return Ok(response);
        }
        // Updates customer details.
        [HttpPut("UpdateCustomer")]
        public async Task<ActionResult<ApiResponse<ConfirmationResponseDTO>>> UpdateCustomer([FromBody] CustomerUpdateDTO customerDto)
        {
            var response = await _customerService.UpdateCustomerAsync(customerDto);
            if (response.StatusCode != 200)
            {
                return StatusCode((int)response.StatusCode, response);
            }
            return Ok(response);
        }
        // Deletes a customer by ID.
        [HttpDelete("DeleteCustomerById/{id}")]
        public async Task<ActionResult<ApiResponse<ConfirmationResponseDTO>>> DeleteCustomer(int id)
        {
            var response = await _customerService.DeleteCustomerAsync(id);
            if (response.StatusCode != 200)
            {
                return StatusCode((int)response.StatusCode, response);
            }
            return Ok(response);
        }

        [HttpGet("auth-endpoint")]
        [Authorize]
        public ActionResult AuthCheck()
        {
            return Ok();
        }
    }
}