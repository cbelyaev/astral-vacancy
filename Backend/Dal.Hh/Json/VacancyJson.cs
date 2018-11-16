using System;
using Newtonsoft.Json;

namespace AstralVacancy.Dal.Hh.Json
{
    /// <summary>
    /// Вакансия
    /// </summary>
    public class VacancyJson
    {
        /// <summary>
        /// Идентификатор вакансии на hh.ru
        /// </summary>
        [JsonProperty("id")]
        public string SyncId { get; set; }

        /// <summary>
        /// Название вакансии
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Описание вакансии, содержит html
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Оклад
        /// </summary>
        public SalaryJson Salary { get; set; }

        /// <summary>
        /// Работодатель
        /// </summary>
        [JsonProperty]
        internal EmployerJson Employer { get; set; }

        /// <summary>
        /// Дата публикации вакансии
        /// </summary>
        [JsonProperty("published_at")]
        public DateTimeOffset? Published { get; set; }
    }
}