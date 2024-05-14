using Autofac;
using MVVM_D2.DataService;
using MVVM_D2.Model;
using MVVM_D2.View;
using MVVM_D2.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_D2.StartUp
{
    public class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<StudentDataService>().As<IDataService<Student>>();
            builder.RegisterType<StudentWindow>().AsSelf();
            builder.RegisterType<StudentViewModel>().AsSelf();

            return builder.Build();
        }
    }
}
