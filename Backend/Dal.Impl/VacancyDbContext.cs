using AstralVacancy.Dal.Impl.Do;
using Microsoft.EntityFrameworkCore;

namespace AstralVacancy.Dal.Impl
{
    internal class VacancyDbContext: DbContext
    {
        public VacancyDbContext()
        {
        }

        public VacancyDbContext(DbContextOptions<VacancyDbContext> options): base(options)
        {
        }

        public DbSet<UserDo> UserSet { get; set; }
        public DbSet<VacancyDo> VacancySet { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserDo>().HasIndex(x => x.Login).IsUnique();

            modelBuilder.Entity<SalaryDo>();

            modelBuilder.Entity<VacancyDo>().OwnsOne(x => x.Salary).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<VacancyDo>().HasIndex(x => x.SyncId).IsUnique();

            // seeding

            modelBuilder.Entity<UserDo>().HasData(
                new UserDo
                {
                    Id = 1,
                    Login = "admin",
                    FullName = "Админ Админыч Админов",
                    IsAdmin = true,
                    // Qwerty
                    PasswordHash = "AQAAAAEAACcQAAAAEAHzy0ies5x3G6daN4jbaKXfQ7+gmXZeEegCg6vJkysfGBZziXF6O4BBxgqiAeByqw=="
                },
                new UserDo
                {
                    Id = 2,
                    Login = "user",
                    FullName = "Юзер Юзерович Юзеров",
                    IsAdmin = false,
                    // qwerty
                    PasswordHash = "AQAAAAEAACcQAAAAEGSxyWsqQyUCBluehUw5jOfZuk73R4RYfKDmMumxwm0lp2l9faeQu2rr2mVBrW7vNw=="
                }
            );
        }
    }
}