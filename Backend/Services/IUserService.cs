using System.Collections.Generic;
using System.Threading.Tasks;
using AstralVacancy.Entities;

namespace AstralVacancy.Services
{
    /// <summary>
    ///     Сервис управления пользователяи
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        ///     Поиск пользователей согласно аргументам-фильтрам. Значение фаргумента null отключает фильтрацию
        ///     по указанному критерию. Указанный критерии комбинируются с помощью логической операции И.
        /// </summary>
        /// <param name="filterLogin">Подстрока (без учёта регистра) для фильтрации по логину пользователя.</param>
        /// <param name="filterName">Подстрока (без учёта регистра) для фильтрации по имени пользователя.</param>
        /// <param name="isAdmin">Критерий фильтрации пользователей администраторов.</param>
        /// <returns>Объекты найденных пользователей.</returns>
        Task<IEnumerable<User>> FindUsersAsync(string filterLogin, string filterName, bool? isAdmin);

        /// <summary>
        ///     Осуществляет аутентификацию пользователя по логину и паролю.
        /// </summary>
        /// <param name="login">Регистрозависимый логин пользователя.</param>
        /// <param name="password">Пароль пользователя.</param>
        /// <returns>Объект успешно аутетифицированного пользователя. В случае неудачи возвращается null.</returns>
        Task<User> LoginAsync(string login, string password);

        /// <summary>
        ///     Создаёт учётную запись пользователя.
        /// </summary>
        /// <param name="user">Объект будущего пользователя, используются поля Login, FullName и IsAdmin</param>
        /// <param name="password">Пароль будущего пользователя, не может быть пустым и null</param>
        /// <returns>Идентификатор нового пользователя.</returns>
        Task<int> RegisterAsync(User user, string password);

        /// <summary>
        ///     Обновляет данные пользователя (кроме пароля).
        /// </summary>
        /// <param name="user">Объект с обновлёнными данными пользователя, используются Id, Login, FullName и IsAdmin.</param>
        /// <returns>Ничего.</returns>
        Task UpdateAsync(User user);

        /// <summary>
        ///     Обновляет пароль пользователя.
        /// </summary>
        /// <param name="id">Идентификатор пользователя.</param>
        /// <param name="password">Новый пароль пользователя, не может быть пустым.</param>
        /// <returns>Ничего.</returns>
        Task UpdatePasswordAsync(int id, string password);

        /// <summary>
        ///     Удаляет пользователя.
        /// </summary>
        /// <param name="id">Идентификатор удаляемого пользователя.</param>
        /// <returns>Ничего.</returns>
        Task DeleteAsync(int id);

        /// <summary>
        ///     Ищет пользователя по идентификатору. В случае неудачи возвращается null.
        /// </summary>
        /// <param name="id">Идентификатор искомого пользователя</param>
        /// <returns>Объект найденного пользователя или null в случае неудачи.</returns>
        Task<User> FindByIdAsync(int id);
    }
}