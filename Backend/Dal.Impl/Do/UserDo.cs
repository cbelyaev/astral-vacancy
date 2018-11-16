namespace AstralVacancy.Dal.Impl.Do
{
    /// <summary>
    ///     Пользователь
    /// </summary>
    internal class UserDo
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
        ///     Хэш пароля
        /// </summary>
        public string PasswordHash { get; set; }

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