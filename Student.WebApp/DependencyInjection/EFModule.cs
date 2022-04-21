using Autofac;
using Student.DataAcess.Common;
using Student.DataAcess.EF;

namespace Student.WebApp.DependencyInjection
{
    public class EFModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType(typeof(StudentManagerDbContext)).InstancePerLifetimeScope();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();
        }
    }
}
