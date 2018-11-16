using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AstralVacancy.Dal.Impl
{
    internal class DesignTimeDbContextFactory: IDesignTimeDbContextFactory<VacancyDbContext>
    {
        public VacancyDbContext CreateDbContext(string[] args)
        {
            // TODO: куда-то это надо убрать
            var connectionString = @"Host=localhost;Port=5432;Database=vacancy;User ID=postgres;Password=postgres;";

            var builder = new DbContextOptionsBuilder<VacancyDbContext>();
            builder.UseNpgsql(connectionString);
            return new VacancyDbContext(builder.Options);
        }
    }
}