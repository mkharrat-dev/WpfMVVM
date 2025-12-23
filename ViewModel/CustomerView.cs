namespace ViewModel
{
    public class CustomerView : ViewModelBase
    {
        public CustomerView()
        {
            
        }
        public int Id
        {
            get; set
            {
                field = value;
                OnPropertyChanged("Id");
            }
        }
        public string Name
        {
            get; set
            {
                field = value;
                OnPropertyChanged("Name");
            }
        }
        public string Address
        {
            get; set
            {
                field = value;
                OnPropertyChanged("Address");
            }
        }
        public string PostalCode
        {
            get; set
            {
                field = value;
                OnPropertyChanged("PostalCode");
            }
        }
        public string Country
        {
            get; set
            {
                field = value;
                OnPropertyChanged("Country");
            }
        }
        public string Phone
        {
            get; set
            {
                field = value;
                OnPropertyChanged("Phone");
            }
        }
        public string Email
        {
            get; set
            {
                field = value;
                OnPropertyChanged("Email");
            }
        } = string.Empty;
    }
}
