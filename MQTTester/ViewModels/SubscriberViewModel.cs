using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MQTTester.ViewModels
{
    public class SubscriberViewModel : BaseViewModel
    {
        public string Url { get; set; }
        public string Port { get; set; }
        public string Topic { get; set; }
        public string Message { get; set; }
        public bool ConnectedToBroker { get; set; }
        public bool Subscribed { get; set; }

        public ICommand ConnectToBrokerCommand => new Command(async() => await ConnectToBrokerAsync());

        private async Task ConnectToBrokerAsync()
        {
            try
            {
                if (IsBusy) return;
                ConnectedToBroker = !ConnectedToBroker;
            }
            catch
            {
                
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
