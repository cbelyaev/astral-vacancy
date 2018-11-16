using AstralVacancy.Entities;
using Autofac;
using Microsoft.AspNetCore.Identity;

namespace AstralVacancy.Services.Autofac
{
    public class ServicesModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PasswordHasher<User>>().As<IPasswordHasher<User>>()
                .InstancePerDependency();

            builder.RegisterType<UserService>().As<IUserService>()
                .InstancePerDependency();

            builder.RegisterType<VacancyService>().As<IVacancyService>()
                .InstancePerDependency();
        }
    }
}