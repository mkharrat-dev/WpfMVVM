using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;
using System.Windows.Navigation;
using ViewModel;

namespace MyWpfApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IServiceProvider ServiceProvider = null!;
        protected override void OnStartup(StartupEventArgs e)
        {
            var s = new ServiceCollection();
            s.AddSingleton(new MainViewModel(ServiceProvider));
            s.AddTransient<CustomersView>();
            s.AddTransient<CustomerView>();
            s.AddTransient<TestView>();
            ServiceProvider = s.BuildServiceProvider();
            var w = new MainWindow
            {
                DataContext = ServiceProvider.GetService<MainViewModel>()
            };
            w.Show();
        }
    }

}
