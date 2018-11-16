using System.Collections.Generic;
using System.Threading.Tasks;
using AstralVacancy.Entities;

namespace AstralVacancy.Dal.Common
{
    public interface IUserDao
    {
        Task<IEnumerable<User>> FindUsersAsync(string filterLogin, string filterName, bool? isAdmin);
        Task<int> RegisterAsync(User user);
        Task UpdateAsync(User user);
        Task DeleteAsync(int id);
        Task<User> FindByLoginAsync(string login);
        Task<User> FindByIdAsync(int id);
    }
}