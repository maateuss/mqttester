using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace MQTTester.ViewModels
{
    public class PublisherViewModel : BaseViewModel
    {
        public string Topico { get; set; }
        public ICommand RandomCommand => new Command(() => { Topico = "xesquedele"; });
    }
}

