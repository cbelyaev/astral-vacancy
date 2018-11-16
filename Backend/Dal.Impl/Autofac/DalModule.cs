using AstralVacancy.Dal.Common;
using AstralVacancy.Dal.Impl.Dao;
using Autofac;

namespace AstralVacancy.Dal.Impl.Autofac
{
    public class DalModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<UserDao>().As<IUserDao>()
                .InstancePerDependency();

            builder.RegisterType<VacancyDao>().As<IVacancyDao>()
                .InstancePerDependency();
        }
    }
}