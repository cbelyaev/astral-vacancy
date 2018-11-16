using AstralVacancy.Dal.Impl.Do;
using AstralVacancy.Entities;
using AutoMapper;

namespace AstralVacancy.Dal.Impl.Mapping
{
    public class DalMappingProfile: Profile
    {
        public DalMappingProfile()
        {
            CreateMap<UserDo, User>();
            CreateMap<User, UserDo>();

            CreateMap<VacancyDo, Vacancy>();
            CreateMap<Vacancy, VacancyDo>();
        }
    }
}
