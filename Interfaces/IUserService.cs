using SpaAndBeautyWebsite.Models;

namespace SpaAndBeautyWebsite.Interfaces
{
    public interface IUserService
    {
        Task<User?> GetProfileAsync(string email);
        Task UpdateProfileAsync(User profile);
    }
}
