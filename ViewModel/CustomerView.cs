using ViewModel.MyLib;

namespace ViewModel
{
    public class CustomerView : ObservableObject
    {
        public int Id
        {
            get;
            set => SetProperty(ref field, value);
        }
        public string Name
        {
            get;
            set => SetProperty(ref field, value);
        }
        public string Address
        {
            get;
            set => SetProperty(ref field, value);
        }
        public string PostalCode
        {
            get;
            set => SetProperty(ref field, value);
        }
        public string Country
        {
            get;
            set => SetProperty(ref field, value);
        }
        public string Phone
        {
            get;
            set => SetProperty(ref field, value);
        }
        public string Email
        {
            get;
            set => SetProperty(ref field, value);
        } = string.Empty;
    }
}
