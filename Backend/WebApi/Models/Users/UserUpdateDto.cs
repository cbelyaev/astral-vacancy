using System.ComponentModel.DataAnnotations;

namespace AstralVacancy.WebApi.Models.Users
{
    /// <summary>
    ///     Модель обновления данных пользователя
    /// </summary>
    public class UserUpdateDto
    {
        /// <summary>
        ///     Идентификатор пользователя
        /// </summary>
        [Required]
        public int Id { get; set; }

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
    }
}