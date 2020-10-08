using System;
using System.ComponentModel;

namespace MQTTester.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public bool IsBusy { get; set; }
        public BaseViewModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
