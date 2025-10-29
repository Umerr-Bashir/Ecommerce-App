using EcommerceApp.DTOs;
using ECommerceApp.DTOs.CustomerDTOs;

namespace EcommerceApp.Service.Customer_Service
{
    public interface ICustomerService
    {
        Task<ApiResponse<CustomerResponseDTO>> GetCustomerByIdAsync(int id);
        Task<ApiResponse<ConfirmationResponseDTO>> UpdateCustomerAsync(CustomerUpdateDTO customerDto);
        Task<ApiResponse<ConfirmationResponseDTO>> DeleteCustomerAsync(int id);

    }
}
