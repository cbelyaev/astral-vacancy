using System.ComponentModel.DataAnnotations;

namespace AstralVacancy.WebApi.Models.Users
{
    /// <summary>
    ///     Модель регистрации пользователя
    /// </summary>
    public class UserRegisterDto
    {
        /// <summary>
        ///     Login пользователя
        /// </summary>
        [Required]
        public string Login { get; set; }

        /// <summary>
        ///     Флаг админа
        /// </summary>
        [Required]
        public bool IsAdmin { get; set; }

        /// <summary>
        ///     Полное имя
        /// </summary>
        [Required]
        public string FullName { get; set; }

        /// <summary>
        ///     Пароль
        /// </summary>
        [Required]
        public string Password { get; set; }
    }
}