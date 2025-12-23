using System.Collections.ObjectModel;
using System.Windows.Input;

namespace ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<CustomerView> _customers;
        private ICommand _SubmitCommand;
        public MainViewModel()
        {
            Customer = new CustomerView();
            Customers=new ObservableCollection<CustomerView>();
            LoadCustomers();
        }

        public CustomerView Customer
        {
            get;

            set
            {
                field = value;
                OnPropertyChanged("Customer");
            }
        }
        public ObservableCollection<CustomerView> Customers
        {
            get => _customers;

            set
            {
                _customers = value;
                OnPropertyChanged("Customers");
            }
        }
        public ICommand LoadCommand
        {
            get
            {
                if (_SubmitCommand == null)
                {
                    _SubmitCommand = new RelayCommand(param => this.LoadCustomers(), (_customers) => { return Customers != null; });
                }
                return _SubmitCommand;
            }
        }
        private void LoadCustomers()
        {
            Customers = new ObservableCollection<CustomerView>
                    {
                        new CustomerView { Id = 1, Name = "Alice", Address = "",PostalCode="",Country="France",Email="xx.yy@test.com",Phone="06.xx.xx.xx.xx" },
                        new CustomerView { Id = 2, Name = "Bob", Address = "",PostalCode="",Country="France",Email="xx.yy@test.com",Phone="06.xx.xx.xx.xx" },
                        new CustomerView { Id = 3, Name = "Charlie", Address = "",PostalCode="",Country="France",Email="xx.yy@test.com",Phone="06.xx.xx.xx.xx" },
                        new CustomerView { Id = 3, Name = "Sebia", Address = "",PostalCode="",Country="France",Email="xx.yy@test.com",Phone="06.xx.xx.xx.xx" },
                        new CustomerView { Id = 3, Name = "ECM", Address = "",PostalCode="",Country="France",Email="xx.yy@test.com",Phone="06.xx.xx.xx.xx" },
                        new CustomerView { Id = 3, Name = "Altec-Consulting", Address = "",PostalCode="",Country="France",Email="xx.yy@test.com",Phone="06.xx.xx.xx.xx" }
                    };
        }
    }
}
