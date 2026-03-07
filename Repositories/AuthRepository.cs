// Repositories/AuthRepository.cs
using backend_trial.Data;
using backend_trial.Models.Domain;
using backend_trial.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace backend_trial.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly IdeaBoardDbContext context;

        public AuthRepository(IdeaBoardDbContext context)
        {
            this.context = context;
        }

        public async Task<bool> UserExistsAsync(string email)
        {
            // Consider normalizing to lower-case consistently (optional if you already do)
            return await context.Users.AnyAsync(u => u.Email == email);
        }

        public async Task<int> CountAdminsAsync()
        {
            return await context.Users.CountAsync(u => u.Role == UserRole.Admin);
        }

        public async Task CreateUserAsync(User user)
        {
            context.Users.Add(user);
            await context.SaveChangesAsync();
        }

        public async Task<User?> GetUserByEmailAsync(string email)
        {
            return await context.Users.FirstOrDefaultAsync(u => u.Email == email);
        }
    }
}