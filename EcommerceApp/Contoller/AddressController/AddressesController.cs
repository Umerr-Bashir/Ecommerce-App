using EcommerceApp.DTOs;
using EcommerceApp.DTOs.AddressDTO;
using EcommerceApp.Service.Address_Service;
using ECommerceApp.DTOs.AddressesDTOs;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EcommerceApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        private readonly IAddressService _addressService;

        public AddressesController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpPost("CreateAddress")]
        public async Task<ActionResult<ApiResponse<ConfirmationResponseDTO>>> CreateAddress([FromBody] AddressCreateDTO addressDto)
        {
            var response = await _addressService.CreateAddressAsync(addressDto);
            if (response.StatusCode != 200) return StatusCode(response.StatusCode, response);
            return Ok(response);
        }


        [HttpGet("GetAddressById/{id}")]
        public async Task<ActionResult<ApiResponse<AddressResponseDTO>>> GetAddressById(int id)
        {
            var response = await _addressService.GetAddressByIdAsync(id);
            if (response.StatusCode != 200) return StatusCode(response.StatusCode, response);
            return Ok(response);
        }

        [HttpPut("UpdateAddress")]
        public async Task<ActionResult<ApiResponse<ConfirmationResponseDTO>>> UpdateAddress([FromBody] AddressUpdateDTO addressDto)
        {
            var response = await _addressService.UpdateAddressAsync(addressDto);
            if (response.StatusCode != 200) return StatusCode(response.StatusCode, response);
            return Ok(response);
        }

        [HttpDelete("DeleteAddress/{id}")]
        public async Task<ActionResult<ApiResponse<ConfirmationResponseDTO>>> DeleteAddress(int id)
        {
            var response = await _addressService.DeleteAddressAsync(id);
            if (response.StatusCode != 200) return StatusCode(response.StatusCode, response);
            return Ok(response);
        }

        [HttpGet("GetAddressesByCustomer/{customerId}")]
        public async Task<ActionResult<ApiResponse<List<AddressResponseDTO>>>> GetAddressesByCustomer(int customerId)
        {
            var response = await _addressService.GetAllAddressesByCustomerIdAsync(customerId);
            if (response.StatusCode != 200) return StatusCode(response.StatusCode, response);
            return Ok(response);
        }
    }
}
