using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AstralVacancy.Dal.Common;
using AstralVacancy.Entities;

namespace AstralVacancy.Services
{
    public class VacancyService: IVacancyService
    {
        private readonly IHhDao _hhDao;
        private readonly IVacancyDao _vacancyDao;

        public VacancyService(IVacancyDao vacancyDao, IHhDao hhDao)
        {
            _vacancyDao = vacancyDao;
            _hhDao = hhDao;
        }

        public async Task<IEnumerable<Vacancy>> FindVacanciesAsync(string text)
        {
            return await _vacancyDao.FindVacanciesAsync(text);
        }

        public async Task<VacanciesUpdateResult> UpdateVacansiesAsync()
        {
            var result = new VacanciesUpdateResult();
            try
            {
                var syncIds = await _hhDao.GetLastVacancyIdsAsync();
                var existingSyncIds = await _vacancyDao.FindExistingSyncIds(syncIds);
                var newSyncIds = syncIds.Where(id => !existingSyncIds.Contains(id));
                var newVacancies = await _hhDao.GetVacancies(newSyncIds);
                var ids = await _vacancyDao.AddRangeAsync(newVacancies);
                result.AddedCount = ids.Length;
            }
            catch (Exception ex)
            {
                result.ErrorMessage = ex.Message;
            }

            return result;
        }

        public async Task<Vacancy> FindByIdAsync(int id)
        {
            return await _vacancyDao.FindById(id);
        }

        public async Task DeleteAsync(int id)
        {
            await _vacancyDao.DeleteAsync(id);
        }
    }
}