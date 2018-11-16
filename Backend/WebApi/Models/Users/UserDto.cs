namespace AstralVacancy.WebApi.Models.Users
{
    /// <summary>
    ///     Модель отображения пользователя
    /// </summary>
    public class UserDto
    {
        /// <summary>
        ///     Идентификатор пользователя
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///     Login пользователя
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        ///     Флаг админа
        /// </summary>
        public bool IsAdmin { get; set; }

        /// <summary>
        ///     Полное имя
        /// </summary>
        public string FullName { get; set; }
    }
}