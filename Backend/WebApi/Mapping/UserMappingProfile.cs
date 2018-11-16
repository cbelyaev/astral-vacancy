using AstralVacancy.Entities;
using AstralVacancy.WebApi.Models.Users;
using AutoMapper;

namespace AstralVacancy.WebApi.Mapping
{
    public class UserMappingProfile: Profile
    {
        public UserMappingProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<User, LoginResultDto>();

            CreateMap<UserRegisterDto, User>()
                .ForMember(x => x.Id, opt => opt.Ignore())
                .ForMember(x => x.PasswordHash, opt => opt.Ignore());

            CreateMap<UserUpdateDto, User>()
                .ForMember(x => x.PasswordHash, opt => opt.Ignore());
        }
    }
}