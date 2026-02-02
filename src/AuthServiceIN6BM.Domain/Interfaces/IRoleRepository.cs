using AuthServiceIN6BM.Domain.Entities;
namespace AuthServiceIN6BM.Domain.Interfaces;

public interface IRoleRepository
{
    Task<Role?> GetByNameAsync(string name);
    Task<int> CountUserInRoleAsync(string roleName);
    Task<IReadOnlyList<User>> GetUserByRoleAsync(string roleName);
    Task<IReadOnlyList<string>> GetUserRoleNamesAsync(string userId);
}