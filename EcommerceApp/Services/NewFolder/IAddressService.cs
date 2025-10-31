using EcommerceApp.DTOs;
using EcommerceApp.DTOs.AddressDTO;
using ECommerceApp.DTOs.AddressesDTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EcommerceApp.Service.Address_Service
{
    public interface IAddressService
    {
        Task<ApiResponse<AddressResponseDTO>> GetAddressByIdAsync(int id);
        Task<ApiResponse<List<AddressResponseDTO>>> GetAllAddressesByCustomerIdAsync(int customerId);
        Task<ApiResponse<ConfirmationResponseDTO>> CreateAddressAsync(AddressCreateDTO addressDto);
        Task<ApiResponse<ConfirmationResponseDTO>> UpdateAddressAsync(AddressUpdateDTO addressDto);
        Task<ApiResponse<ConfirmationResponseDTO>> DeleteAddressAsync(int id);
    }
}
