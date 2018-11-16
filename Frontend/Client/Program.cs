using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace AstralVacancy.Client
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var basePath = "http://localhost:5000/";
            if (args != null && args.Length > 0) 
                basePath = args[0];

            Console.WriteLine($"Using base path: {basePath}");

            Console.WriteLine();
            Console.WriteLine("Login...");
            var loginApi = new LoginApi(basePath);
            var loginResult = await loginApi.LoginAsync(new UserLoginDto("admin", "Qwerty"));
            if (!string.IsNullOrEmpty(loginResult.ErrorMessage))
            {
                Console.WriteLine($"Login error: {loginResult.ErrorMessage}");
                return;
            }

            Console.WriteLine($"Login as {loginResult.User.Login} ({loginResult.User.FullName}) is successful");
            var userApi = new UserApi(basePath)
            {
                Configuration =
                {
                    DefaultHeader = new Dictionary<string, string> {{"Authorization", "Bearer " + loginResult.Token}}
                }
            };

            var users = await userApi.GetUsersAsync(new UserFilterDto());
            Console.WriteLine("Users:");
            foreach (var u in users)
                Console.WriteLine($"{u.Id}, {u.Login}, {u.FullName}, {u.IsAdmin}");

            var vacancyApi = new VacancyApi(basePath)
            {
                Configuration =
                {
                    DefaultHeader = new Dictionary<string, string> {{"Authorization", "Bearer " + loginResult.Token}}
                }
            };

            Console.WriteLine();
            Console.WriteLine("Update vacancies...");
            var updateResult = await vacancyApi.UpdateVacanciesAsync();
            if (!string.IsNullOrEmpty(updateResult.ErrorMessage))
            {
                Console.WriteLine($"Update error: {updateResult.ErrorMessage}");
                return;
            }

            Console.WriteLine($"Adding {updateResult.AddedCount} new vacancies is successful");

            Console.WriteLine();
            Console.WriteLine("Getting vacancies...");
            var vacancies = await vacancyApi.FindVacanciesAsync(string.Empty);
            foreach (var v in vacancies)
            {
                Console.WriteLine($"Id: {v.Id}");
                Console.WriteLine($"SyncId: {v.SyncId}");
                Console.WriteLine($"Name: {v.Name}");
                Console.WriteLine($"EmployerName: {v.EmployerName}");
                Console.WriteLine($"Published: {v.Published}");
                Console.WriteLine($"Salary:{SalaryToString(v.Salary)}");
                Console.WriteLine($"Description: {v.Description}");
                Console.WriteLine();
            }
        }

        private static string SalaryToString(SalaryDto salary)
        {
            if (salary?.From == null && salary?.To == null) 
                return "None";
            var sb = new StringBuilder();
            if (salary.From.HasValue)
                sb.Append($" from {salary.From}");
            if (salary.To.HasValue)
                sb.Append($" to {salary.To}");
            if (salary.Currency != null)
                sb.Append($" {salary.Currency ?? "RUR"}");
            if (salary.Gross == true)
                sb.Append(" (Gross)");
            return sb.ToString();
        }
    }
}