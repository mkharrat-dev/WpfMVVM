namespace ViewModel
{
    public class CustomerView : ObservableObject
    {
        public int Id
        {
            get;
            set
            {
                field = value;
                RaisePropertyChangedEvent("Id");
            }
        }
        public string Name
        {
            get;
            set
            {
                field = value;
                RaisePropertyChangedEvent("Name");
            }
        }
        public string Address
        {
            get;
            set
            {
                field = value;
                RaisePropertyChangedEvent("Address");
            }
        }
        public string PostalCode
        {
            get;
            set
            {
                field = value;
                RaisePropertyChangedEvent("PostalCode");
            }
        }
        public string Country
        {
            get;
            set
            {
                field = value;
                RaisePropertyChangedEvent("Country");
            }
        }
        public string Phone
        {
            get;
            set
            {
                field = value;
                RaisePropertyChangedEvent("Phone");
            }
        }
        public string Email
        {
            get;
            set
            {
                field = value;
                RaisePropertyChangedEvent("Email");
            }
        } = string.Empty;
    }
}
