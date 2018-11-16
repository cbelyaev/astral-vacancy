using AstralVacancy.Dal.Common;
using Autofac;
using HeadhunterApi;

namespace AstralVacancy.Dal.Hh.Autofac
{
    public class HhModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<HhDao>().As<IHhDao>()
                .InstancePerDependency();
        }
    }
}