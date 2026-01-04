using System;
using System.Collections.ObjectModel;
using ViewModel.MyLib;

namespace ViewModel
{
    public class CustomersView : ObservableObject
    {
        public ObservableCollection<CustomerView> Customers
        {
            get;
            set => SetProperty(ref field, value);
        }

        public CustomersView()
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
