using EcommerceApp.DTOs;
using EcommerceApp.DTOs.CustomerDTO;
using ECommerceApp.DTOs.CustomerDTOs;

namespace EcommerceApp.Service.AuthService
{
    public interface IAuthService
    {
        Task<ApiResponse<CustomerResponseDTO>> RegisterCustomerAsync(CustomerRegistrationDTO customerDto);
        Task<ApiResponse<LoginResponseDTO>> LoginAsync(LoginDTO loginDto);
        Task<ApiResponse<ConfirmationResponseDTO>> ChangePasswordAsync(ChangePasswordDTO changePasswordDto);
    }
}
