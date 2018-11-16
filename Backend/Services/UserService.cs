using System.Collections.Generic;
using System.Threading.Tasks;
using AstralVacancy.Common;
using AstralVacancy.Dal.Common;
using AstralVacancy.Entities;
using Microsoft.AspNetCore.Identity;

namespace AstralVacancy.Services
{
    public class UserService: IUserService
    {
        private readonly IPasswordHasher<User> _hasher;
        private readonly IUserDao _userDao;

        public UserService(IUserDao userDao, IPasswordHasher<User> hasher)
        {
            _userDao = userDao;
            _hasher = hasher;
        }

        public async Task<IEnumerable<User>> FindUsersAsync(string filterLogin, string filterName, bool? isAdmin)
        {
            return await _userDao.FindUsersAsync(filterLogin, filterName, isAdmin);
        }

        public async Task<User> LoginAsync(string login, string password)
        {
            var user = await _userDao.FindByLoginAsync(login);
            if (user == null)
                return null;
            var result = _hasher.VerifyHashedPassword(user, user.PasswordHash, password);
            return result == PasswordVerificationResult.Failed ? null : user;
        }

        public async Task<int> RegisterAsync(User user, string password)
        {
            user.PasswordHash = _hasher.HashPassword(user, password);
            return await _userDao.RegisterAsync(user);
        }

        public async Task UpdateAsync(User user)
        {
            var oldUser = await _userDao.FindByIdAsync(user.Id);
            if (oldUser == null)
                throw new EntityNotFoundException(ErrorText.NotFound, user.Id);
            // protect password
            user.PasswordHash = oldUser.PasswordHash;
            await _userDao.UpdateAsync(user);
        }

        public async Task UpdatePasswordAsync(int id, string password)
        {
            var user = await _userDao.FindByIdAsync(id);
            if (user == null)
                throw new EntityNotFoundException(ErrorText.NotFound, id);
            user.PasswordHash = _hasher.HashPassword(user, password);
            await _userDao.UpdateAsync(user);
        }

        public async Task DeleteAsync(int id)
        {
            await _userDao.DeleteAsync(id);
        }

        public async Task<User> FindByIdAsync(int id)
        {
            return await _userDao.FindByIdAsync(id);
        }
    }
}