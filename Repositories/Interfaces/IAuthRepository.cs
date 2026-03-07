// Repositories/Interfaces/IAuthRepository.cs
using backend_trial.Models.Domain;

namespace backend_trial.Repositories.Interfaces
{
    public interface IAuthRepository
    {
        Task<bool> UserExistsAsync(string email);
        Task<int> CountAdminsAsync();
        Task CreateUserAsync(User user);
        Task<User?> GetUserByEmailAsync(string email);
    }
}