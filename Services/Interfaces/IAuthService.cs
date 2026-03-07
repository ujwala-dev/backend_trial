// Services/Interfaces/IAuthService.cs
using backend_trial.Models.DTO.Auth;

namespace backend_trial.Services.Interfaces
{
    public interface IAuthService
    {
        Task<(bool Success, string Message)> RegisterAsync(RegisterRequestDto request);
        Task<(bool Success, AuthResponseDto? User, string Message, int statusCode)> LoginAsync(LoginRequestDto request);
    }
}