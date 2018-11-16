using AstralVacancy.Dal.Hh.Autofac;
using AstralVacancy.Dal.Hh.Mapping;
using AstralVacancy.Dal.Impl.Autofac;
using AstralVacancy.Dal.Impl.Config;
using AstralVacancy.Dal.Impl.Mapping;
using AstralVacancy.Services.Autofac;
using AstralVacancy.WebApi.Mapping;
using Autofac;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace AstralVacancy.WebApi.Autofac
{
    public static class AutofacConfig
    {
        public static void FillConfig(ContainerBuilder builder)
        {
            builder
                .RegisterModule<ServicesModule>()
                .RegisterModule<DalModule>()
                .RegisterModule<HhModule>();

            builder.RegisterInstance(Startup.Configuration)
                .As<IConfigurationRoot>();

            builder.RegisterInstance(InitMapper())
                .As<IMapper>()
                .SingleInstance();

            var dalOptions = Options.Create(new DalConfig
            {
                ConnectionString = Startup.Configuration.GetConnectionString("DefaultConnection")
            });

            builder.RegisterInstance(dalOptions).As<IOptions<DalConfig>>();

            //builder.RegisterLogger();
        }

        private static IMapper InitMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<UserMappingProfile>();
                cfg.AddProfile<DalMappingProfile>();
                cfg.AddProfile<HhMappingProfile>();
                cfg.AddProfile<VacancyMappingProfile>();
            });

            var mapper = config.CreateMapper();
            return mapper;
        }
    }
}