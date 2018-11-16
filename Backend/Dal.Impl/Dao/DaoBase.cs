using AstralVacancy.Dal.Impl.Config;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace AstralVacancy.Dal.Impl.Dao
{
    internal abstract class DaoBase
    {
        protected readonly DbContextOptions<VacancyDbContext> DbConfig;

        protected DaoBase(IOptions<DalConfig> config)
        {
            DbConfig = new DbContextOptionsBuilder<VacancyDbContext>()
                .UseNpgsql(config.Value.ConnectionString)
                .Options;
        }
    }
}