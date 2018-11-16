namespace AstralVacancy.Entities
{
    /// <summary>
    ///     Результат синхронизации вакансий
    /// </summary>
    public class VacanciesUpdateResult
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