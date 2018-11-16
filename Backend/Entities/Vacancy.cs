using System;

namespace AstralVacancy.Entities
{
    /// <summary>
    ///     Вакансия
    /// </summary>
    public class Vacancy
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
        public Salary Salary { get; set; }

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