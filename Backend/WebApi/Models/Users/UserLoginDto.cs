using System.ComponentModel.DataAnnotations;

namespace AstralVacancy.WebApi.Models.Users
{
    /// <summary>
    ///     Модель аутентификации пользователя
    /// </summary>
    public class UserLoginDto
    {
        /// <summary>
        ///     Логин пользователя
        /// </summary>
        [Required]
        public string Login { get; set; }

        /// <summary>
        ///     Пароль пользователя
        /// </summary>
        [Required]
        public string Password { get; set; }
    }
}