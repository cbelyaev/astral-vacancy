using AstralVacancy.Entities;
using AstralVacancy.WebApi.Models.Vacancies;
using AutoMapper;

namespace AstralVacancy.WebApi.Mapping
{
    public class VacancyMappingProfile: Profile
    {
        public VacancyMappingProfile()
        {
            CreateMap<VacanciesUpdateResult, VacanciesUpdateResultDto>();

            CreateMap<Vacancy, VacancyDto>();

            CreateMap<Salary, SalaryDto>();
        }
    }
}