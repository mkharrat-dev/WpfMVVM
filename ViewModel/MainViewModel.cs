using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using ViewModel.MyLib;

namespace ViewModel
{
    public class MainViewModel : ObservableObject
    {
        private IServiceProvider ServiceProvider = null!;
        public object CurrentPage
        {
            get;
            set => SetProperty(ref field, value);
        }

        public MainViewModel(IServiceProvider serviceProvider)
        {
            ServiceProvider=serviceProvider;

        }
        public ICommand customers => new RelayCommand(() => CurrentPage = ServiceProvider.GetService(typeof(CustomersView)) as CustomersView);
    }

}
