using Autofac;
using DemoLibrary.BusinessObject;
using DemoWebLibrary.ApplicationDbContext;
using DemoWebLibrary.BusinessObject;
using DemoWebLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebLibrary
{
    public class LibraryModule:Module
    {
        private readonly string _connectionstring;
        private readonly string _assemblyname;
        public LibraryModule(string connectionstring, string assemblyname)
        {
            _connectionstring = connectionstring;
            _assemblyname = assemblyname;
        }
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<StudentDbContext>().AsSelf()
                .WithParameter("connectionstring", _connectionstring)
                .WithParameter("assemblyname", _assemblyname)
                .InstancePerLifetimeScope();
            builder.RegisterType<StudentService>().As<IStudentService>()
                .InstancePerLifetimeScope();
            builder.RegisterType<BStudent>().As<IBStudent>()
               .InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
