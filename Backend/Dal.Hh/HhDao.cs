using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AstralVacancy.Dal.Common;
using AstralVacancy.Dal.Hh.Json;
using AstralVacancy.Entities;
using AutoMapper;
using Newtonsoft.Json;

namespace HeadhunterApi
{
    public class HhDao: IHhDao
    {
        private const string VacansiesUrl = "https://api.hh.ru/vacancies/";
        private const string ItSpecializationId = "1";
        private const string UfaAreaId = "99";
        private const string PeriodDays = "30";
        private const string OrderBy = "publication_time";

        private readonly HttpClient _client;
        private readonly IMapper _mapper;

        public HhDao(IMapper mapper)
        {
            _mapper = mapper;
            _client = new HttpClient
            {
                DefaultRequestHeaders =
                {
                    // required by HH API
                    {"User-Agent", "AstalJobs Taks Application"}
                }
            };
        }


        public async Task<string[]> GetLastVacancyIdsAsync()
        {
            var url = $"{VacansiesUrl}" +
                      $"?specialization={ItSpecializationId}" +
                      $"&area={UfaAreaId}" +
                      $"&period={PeriodDays}" +
                      $"&order_by={OrderBy}" +
                      "&per_page=50" +
                      "&page=0";
            var response = await _client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadAsStringAsync();
            var vacancies = JsonConvert.DeserializeObject<VacanciesJson>(result);
            return vacancies.Items.Select(v => v.Id).ToArray();
        }

        public async Task<Vacancy> GetVacancyByIdAsync(string id)
        {
            var response = await _client.GetAsync($"{VacansiesUrl}{id}");
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadAsStringAsync();
            var vacancyJson = JsonConvert.DeserializeObject<VacancyJson>(result);
            return _mapper.Map<Vacancy>(vacancyJson);
        }

        public async Task<IEnumerable<Vacancy>> GetVacancies(IEnumerable<string> ids)
        {
            return await Task.WhenAll(ids.Select(async x => await GetVacancyByIdAsync(x)));
        }
    }
}