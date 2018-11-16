using System.Collections.Generic;
using System.Threading.Tasks;
using AstralVacancy.Common;
using AstralVacancy.Services;
using AstralVacancy.WebApi.Infrastructure;
using AstralVacancy.WebApi.Models.Vacancies;
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
    public class VacancyController: Controller
    {
        private readonly IMapper _mapper;
        private readonly IVacancyService _vacancyService;

        public VacancyController(IVacancyService vacancyService, IMapper mapper)
        {
            _vacancyService = vacancyService;
            _mapper = mapper;
        }

        /// <summary>
        /// Добавляет в локальное хранилище новые вакансии из внешнего источника
        /// </summary>
        /// <returns></returns>
        [HttpGet("vacancies/update")]
        public async Task<VacanciesUpdateResultDto> UpdateVacancies()
        {
            if (!HttpContext.User.IsAdmin())
                throw new InsufficientRightsException();

            var result = await _vacancyService.UpdateVacansiesAsync();
            return _mapper.Map<VacanciesUpdateResultDto>(result);
        }

        /// <summary>
        /// Ищет вакансии в локальном хранилище
        /// </summary>
        /// <param name="text">Подстрока поиска</param>
        /// <returns></returns>
        [HttpGet("vacancies")]
        public async Task<IEnumerable<VacancyDto>> FindVacancies(string text)
        {
            var result = await _vacancyService.FindVacanciesAsync(text);
            return _mapper.Map<IEnumerable<VacancyDto>>(result);
        }

        /// <summary>
        /// Ищет вакансию по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор вакансии</param>
        /// <returns></returns>
        [HttpGet("vacancy/{id}")]
        public async Task<VacancyDto> GetVacancy(int id)
        {
            var result = await _vacancyService.FindByIdAsync(id);
            if (result == null)
                throw new EntityNotFoundException(ErrorText.NotFound, id);

            return _mapper.Map<VacancyDto>(result);
        }

        /// <summary>
        /// Удаляет вакансию
        /// </summary>
        /// <param name="id">Идентификатор удаляемой вакансии</param>
        /// <returns></returns>
        [HttpDelete("vacancy/{id}")]
        public async Task DeleteVacancy(int id)
        {
            if (!HttpContext.User.IsAdmin())
                throw new InsufficientRightsException();

            await _vacancyService.DeleteAsync(id);
        }
    }
}