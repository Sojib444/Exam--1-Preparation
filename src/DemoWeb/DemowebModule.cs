using Autofac;
using DemoWeb.Areas.Admin.Models;

namespace DemoWeb
{
    public class DemowebModule:Module 
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CreateStudent>().As<ICreateStudent>()
                .InstancePerLifetimeScope();
            base.Load(builder);
        }
    }
}
