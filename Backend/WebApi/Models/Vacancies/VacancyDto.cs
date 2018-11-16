using System;

namespace AstralVacancy.WebApi.Models.Vacancies
{
    public class VacancyDto
    {
        /// <summary>
        ///     Идентификатор вакансии
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///     Идентификатор вакансии на hh.ru
        /// </summary>
        public string SyncId { get; set; }

        /// <summary>
        ///     Название вакансии
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Описание вакансии, содержит html
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        ///     Оклад
        /// </summary>
        public SalaryDto Salary { get; set; }

        /// <summary>
        ///     Работодатель
        /// </summary>
        public string EmployerName { get; set; }

        /// <summary>
        ///     Дата публикации вакансии
        /// </summary>
        public DateTimeOffset? Published { get; set; }
    }
}