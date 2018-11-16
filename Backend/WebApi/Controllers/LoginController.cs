using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Threading.Tasks;
using AstralVacancy.Common;
using AstralVacancy.Services;
using AstralVacancy.WebApi.Config;
using AstralVacancy.WebApi.Models.Users;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace AstralVacancy.WebApi.Controllers
{
    [ApiController]
    [Route("api")]
    [Consumes("application/json")]
    [Produces("application/json")]
    public class LoginController: ControllerBase
    {
        private readonly JwtConfig _jwtConfig;
        private readonly IMapper _mapper;
        private readonly IUserService _userService;

        public LoginController(IUserService userService, IOptions<JwtConfig> jwtOptions, IMapper mapper)
        {
            _userService = userService;
            _jwtConfig = jwtOptions.Value;
            _mapper = mapper;
        }

        /// <summary>
        /// Аутентифицирует пользователя
        /// </summary>
        /// <param name="loginDto">Логин и пароль пользователя</param>
        /// <returns></returns>
        [HttpPost]
        [Route("login")]
        public async Task<LoginResultDto> Login([FromBody] UserLoginDto loginDto)
        {
            var user = await _userService.LoginAsync(loginDto.Login, loginDto.Password);
            if (user == null)
                return new LoginResultDto {ErrorMessage = ErrorText.LoginIncorrect};

            var token = new JwtSecurityToken(
                _jwtConfig.Issuer,
                _jwtConfig.Audience,
                new[] {new Claim(JwtRegisteredClaimNames.Typ, user.IsAdmin.ToString())},
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: new SigningCredentials(
                    new SymmetricSecurityKey(_jwtConfig.KeyBytes),
                    SecurityAlgorithms.HmacSha256)
            );

            var loginResultDto = new LoginResultDto
            {
                User = _mapper.Map<UserDto>(user),
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                ErrorMessage = string.Empty
            };

            return loginResultDto;
        }
    }
}