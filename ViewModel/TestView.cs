using System;
using System.Collections.Generic;
using System.Text;
using ViewModel.MyLib;

namespace ViewModel
{
    public class TestView:ObservableObject
    {
        public string Name
        {
            get;
            set => SetProperty(ref field, value);
        }
    }
}
