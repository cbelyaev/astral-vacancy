namespace AstralVacancy.WebApi.Models.Vacancies
{
    /// <summary>
    ///     Результат синхронизации вакансий
    /// </summary>
    public class VacanciesUpdateResultDto
    {
        /// <summary>
        ///     Количество добавленных вакансий
        /// </summary>
        public int AddedCount { get; set; }

        /// <summary>
        ///     Сообщение об ошибке синхронизации
        /// </summary>
        public string ErrorMessage { get; set; }
    }
}