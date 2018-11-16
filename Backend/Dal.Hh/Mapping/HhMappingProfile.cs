using AstralVacancy.Dal.Hh.Json;
using AstralVacancy.Entities;
using AutoMapper;

namespace AstralVacancy.Dal.Hh.Mapping
{
    public class HhMappingProfile: Profile
    {
        public HhMappingProfile()
        {
            CreateMap<VacancyJson, Vacancy>()
                .ForMember(dst => dst.EmployerName, opt => opt.MapFrom(src => src.Employer.Name))
                .ForMember(dst => dst.Id, opt => opt.Ignore())
                .ForMember(dst => dst.Salary, opt => opt.NullSubstitute(new SalaryJson()));

            CreateMap<SalaryJson, Salary>();
        }
    }
}