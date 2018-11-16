namespace AstralVacancy.WebApi.Models.Users
{
    /// <summary>
    ///     Модель фильтрации пользователей
    /// </summary>
    public class UserFilterDto
    {
        /// <summary>
        /// Подстрока для фильтрации по логину
        /// </summary>
        public string LoginFilter { get; set; }

        /// <summary>
        /// Подстрока для фильтрации по полному имени
        /// </summary>
        public string FullNameFilter { get; set; }

        /// <summary>
        /// Фильтрация только админов или только простых пользователей
        /// </summary>
        public bool? IsAdminFilter { get; set; }
    }
}