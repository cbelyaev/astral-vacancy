using System.Collections.Generic;
using System.Threading.Tasks;
using AstralVacancy.Entities;

namespace AstralVacancy.Services
{
    /// <summary>
    /// Сервис управления вакансиями
    /// </summary>
    public interface IVacancyService
    {
        /// <summary>
        /// Ищет вакансии.
        /// </summary>
        /// <param name="text">Подстрока (без учёта регистра) для фильтрации по названию или описанию вакансии</param>
        /// <returns>Объекты найденных вакансий </returns>
        Task<IEnumerable<Vacancy>> FindVacanciesAsync(string text);

        /// <summary>
        /// Обновляет вакансии из внешнего источника
        /// </summary>
        /// <returns>Объект результата обновления</returns>
        Task<VacanciesUpdateResult> UpdateVacansiesAsync();

        /// <summary>
        /// Ищет вакансии по идентификатору. В случае неудачи возвращается null.
        /// </summary>
        /// <param name="id">Идентификатор вакансии.</param>
        /// <returns>Объект найденной вакансии или null в случае неудачи.</returns>
        Task<Vacancy> FindByIdAsync(int id);

        /// <summary>
        /// Удаляет вакансию.
        /// </summary>
        /// <param name="id">Идентификатор удаляемой вакансии.</param>
        /// <returns>Ничего.</returns>
        Task DeleteAsync(int id);
    }
}