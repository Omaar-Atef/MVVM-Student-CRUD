using Autofac;
using MVVM_D2.DataService;
using MVVM_D2.StartUp;
using MVVM_D2.View;
using MVVM_D2.ViewModel;
using System.Configuration;
using System.Data;
using System.Windows;

namespace MVVM_D2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var container = ContainerConfig.Configure();
            StudentWindow StdWindow = container.Resolve<StudentWindow>();
            StdWindow.Show();

        }
    }

}
