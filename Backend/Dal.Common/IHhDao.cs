using System.Collections.Generic;
using System.Threading.Tasks;
using AstralVacancy.Entities;

namespace AstralVacancy.Dal.Common
{
    /// <summary>
    /// </summary>
    public interface IHhDao
    {
        /// <summary>
        ///     Запрашивает у hh.ru идентификаторы последних 50 вакансий
        /// </summary>
        /// <returns>Массив строк-идентификаторов вакансий</returns>
        Task<string[]> GetLastVacancyIdsAsync();

        /// <summary>
        ///     Запрашивает у hh.ru полное описание вакансии с идентификатором id
        /// </summary>
        /// <param name="id">Идентификатор требуемой вакансии</param>
        /// <returns>Полное описание вакансии</returns>
        Task<Vacancy> GetVacancyByIdAsync(string id);

        /// <summary>
        ///     Запрашивает у hh.ru полное описание вакансий с указанными индетификаторами
        /// </summary>
        /// <param name="ids">Коллекция идентификаторов требуемых вакансий</param>
        /// <returns>Коллекцию полных описаний вакансий</returns>
        Task<IEnumerable<Vacancy>> GetVacancies(IEnumerable<string> ids);
    }
}