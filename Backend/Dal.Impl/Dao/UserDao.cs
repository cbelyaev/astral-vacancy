using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AstralVacancy.Common;
using AstralVacancy.Dal.Common;
using AstralVacancy.Dal.Impl.Config;
using AstralVacancy.Dal.Impl.Do;
using AstralVacancy.Entities;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace AstralVacancy.Dal.Impl.Dao
{
    internal class UserDao: DaoBase, IUserDao
    {
        private readonly IMapper _mapper;

        public UserDao(IOptions<DalConfig> config, IMapper mapper): base(config)
        {
            _mapper = mapper;
        }

        public async Task<IEnumerable<User>> FindUsersAsync(string filterLogin, string filterName, bool? isAdmin)
        {
            using (var db = new VacancyDbContext(DbConfig))
            {
                var query = db.UserSet.AsQueryable();

                if (!string.IsNullOrEmpty(filterLogin))
                {
                    var filter = filterLogin.ToUpper();
                    query = query.Where(x => x.Login.ToUpper().Contains(filter));
                }

                if (!string.IsNullOrEmpty(filterName))
                {
                    var filter = filterName.ToUpper();
                    query = query.Where(x => x.FullName.ToUpper().Contains(filter));
                }

                if (isAdmin.HasValue) query = query.Where(x => x.IsAdmin == isAdmin.Value);

                var result = await query.ToListAsync();
                return result.Select(_mapper.Map<User>);
            }
        }

        public async Task<int> RegisterAsync(User user)
        {
            using (var db = new VacancyDbContext(DbConfig))
            {
                var userDo = _mapper.Map<UserDo>(user);
                await db.UserSet.AddAsync(userDo);
                await db.SaveChangesAsync();
                return userDo.Id;
            }
        }

        public async Task UpdateAsync(User user)
        {
            using (var db = new VacancyDbContext(DbConfig))
            {
                var userDo = await db.UserSet.FirstOrDefaultAsync(x => x.Id == user.Id);
                if (userDo == null)
                    throw new EntityNotFoundException(ErrorText.NotFound, user.Id);
                _mapper.Map(user, userDo);
                db.UserSet.Update(userDo);
                await db.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(int id)
        {
            using (var db = new VacancyDbContext(DbConfig))
            {
                var entry = db.Entry(new UserDo {Id = id});
                entry.State = EntityState.Deleted;
                await db.SaveChangesAsync();
            }
        }

        public async Task<User> FindByLoginAsync(string login)
        {
            using (var db = new VacancyDbContext(DbConfig))
            {
                var userDo = await db.UserSet.FirstOrDefaultAsync(x => x.Login == login);
                return userDo == null ? null : _mapper.Map<User>(userDo);
            }
        }

        public async Task<User> FindByIdAsync(int id)
        {
            using (var db = new VacancyDbContext(DbConfig))
            {
                var userDo = await db.UserSet.FirstOrDefaultAsync(x => x.Id == id);
                return userDo == null ? null : _mapper.Map<User>(userDo);
            }
        }
    }
}