using System.Collections.Generic;
using System.Threading.Tasks;
using AstralVacancy.Entities;

namespace AstralVacancy.Dal.Common
{
    public interface IVacancyDao
    {
        Task<IEnumerable<Vacancy>> FindVacanciesAsync(string text);
        Task<Vacancy> FindById(int id);
        Task<IEnumerable<string>> FindExistingSyncIds(string[] syncIds);
        Task<int[]> AddRangeAsync(IEnumerable<Vacancy> vacancies);
        Task DeleteAsync(int id);
    }
}