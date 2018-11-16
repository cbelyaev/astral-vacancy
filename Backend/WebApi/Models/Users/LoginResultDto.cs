namespace AstralVacancy.WebApi.Models.Users
{
    /// <summary>
    /// Модель аутентифицированого пользователя
    /// </summary>
    public class LoginResultDto
    {
        /// <summary>
        /// Пользователь
        /// </summary>
        public UserDto User { get; set; }

        /// <summary>
        /// Токен безопасности
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// Сообщение об ошибке
        /// </summary>
        public string ErrorMessage { get; set; }
    }
}