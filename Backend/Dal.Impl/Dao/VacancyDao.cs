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
    internal class VacancyDao: DaoBase, IVacancyDao
    {
        private readonly IMapper _mapper;

        public VacancyDao(IOptions<DalConfig> config, IMapper mapper): base(config)
        {
            _mapper = mapper;
        }

        public async Task<IEnumerable<Vacancy>> FindVacanciesAsync(string text)
        {
            using (var db = new VacancyDbContext(DbConfig))
            {
                var filter = text?.ToUpper() ?? string.Empty;
                var vacansies = await db.VacancySet
                    .Where(x => x.Name.ToUpper().Contains(filter) || x.Description.ToUpper().Contains(filter))
                    .ToListAsync();
                return vacansies.Select(_mapper.Map<Vacancy>);
            }
        }

        public async Task<Vacancy> FindById(int id)
        {
            using (var db = new VacancyDbContext(DbConfig))
            {
                var vacancyDo = await db.VacancySet.FirstOrDefaultAsync(x => x.Id == id);
                return vacancyDo == null ? null : _mapper.Map<Vacancy>(vacancyDo);
            }
        }

        public async Task<IEnumerable<string>> FindExistingSyncIds(string[] syncIds)
        {
            using (var db = new VacancyDbContext(DbConfig))
            {
                return await db.VacancySet
                    .Where(x => syncIds.Contains(x.SyncId))
                    .Select(x => x.SyncId)
                    .ToListAsync();
            }
        }

        public async Task<int[]> AddRangeAsync(IEnumerable<Vacancy> vacancies)
        {
            using (var db = new VacancyDbContext(DbConfig))
            {
                var vacancyDos = vacancies
                    .Select(v => _mapper.Map<VacancyDo>(v))
                    .ToArray(); // to preserve order
                await db.VacancySet.AddRangeAsync(vacancyDos);
                await db.SaveChangesAsync();
                return vacancyDos.Select(v => v.Id).ToArray();
            }
        }

        public async Task DeleteAsync(int id)
        {
            using (var db = new VacancyDbContext(DbConfig))
            {
                var vacancyDo = await db.VacancySet.FirstOrDefaultAsync(x => x.Id == id);
                if (vacancyDo == null)
                    throw new EntityNotFoundException(ErrorText.NotFound, id);
                db.Remove(vacancyDo);
                await db.SaveChangesAsync();
            }
        }
    }
}