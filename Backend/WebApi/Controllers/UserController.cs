using System.Collections.Generic;
using System.Threading.Tasks;
using AstralVacancy.Common;
using AstralVacancy.Entities;
using AstralVacancy.Services;
using AstralVacancy.WebApi.Infrastructure;
using AstralVacancy.WebApi.Models.Users;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AstralVacancy.WebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api")]
    [Consumes("application/json")]
    [Produces("application/json")]
    public class UserController: ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUserService _userService;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        /// <summary>
        /// Ищет пользователей
        /// </summary>
        /// <param name="filterDto">Критерии поиска пользователей</param>
        /// <returns></returns>
        [HttpPost("users")]
        public async Task<IEnumerable<UserDto>> GetUsers(UserFilterDto filterDto)
        {
            var users = await _userService.FindUsersAsync(
                filterDto.LoginFilter,
                filterDto.FullNameFilter,
                filterDto.IsAdminFilter);
            var usersDto = _mapper.Map<IEnumerable<UserDto>>(users);
            return usersDto;
        }

        /// <summary>
        /// Ищет пользователя по его идентификатору
        /// </summary>
        /// <param name="id">Идентификатор пользователя</param>
        /// <returns></returns>
        [HttpGet("user/{id}")]
        public async Task<UserDto> GetUser(int id)
        {
            return _mapper.Map<UserDto>(await _userService.FindByIdAsync(id));
        }

        /// <summary>
        /// Регистрирует нового пользователя
        /// </summary>
        /// <param name="registerDto">Данные нового пользователя</param>
        /// <returns></returns>
        [HttpPost("user")]
        public async Task<UserDto> Register([FromBody] UserRegisterDto registerDto)
        {
            if (!HttpContext.User.IsAdmin())
                throw new InsufficientRightsException();

            var user = _mapper.Map<User>(registerDto);
            var id = await _userService.RegisterAsync(user, registerDto.Password);
            user = await _userService.FindByIdAsync(id);
            return _mapper.Map<UserDto>(user);
        }

        /// <summary>
        /// Изменяет данные пользователя
        /// </summary>
        /// <param name="updateDto">Новые данные пользователя</param>
        /// <returns></returns>
        [HttpPut("user")]
        public async Task UpdateUser([FromBody] UserUpdateDto updateDto)
        {
            if (!HttpContext.User.IsAdmin())
                throw new InsufficientRightsException();

            var user = _mapper.Map<User>(updateDto);
            await _userService.UpdateAsync(user);
        }

        /// <summary>
        /// Изменяет пароль пользователя
        /// </summary>
        /// <param name="id">Идентификатор пользователя</param>
        /// <param name="password">Новый пароль</param>
        /// <returns></returns>
        [HttpPut("user/{id}/password")]
        public async Task UpdatePassword(int id, [FromBody] string password)
        {
            if (!HttpContext.User.IsAdmin())
                throw new InsufficientRightsException();

            await _userService.UpdatePasswordAsync(id, password);
        }

        /// <summary>
        /// Удаляет пользователя
        /// </summary>
        /// <param name="id">Идентификатор удаляемого пользователя</param>
        /// <returns></returns>
        [HttpDelete("user/{id}")]
        public async Task Delete(int id)
        {
            if (!HttpContext.User.IsAdmin())
                throw new InsufficientRightsException();

            await _userService.DeleteAsync(id);
        }
    }
}