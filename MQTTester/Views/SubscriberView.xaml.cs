using System;
using System.Collections.Generic;
using MQTTester.ViewModels;
using Xamarin.Forms;

namespace MQTTester.Views
{
    public partial class SubscriberView : ContentPage
    {
        public SubscriberView()
        {
            InitializeComponent();
            BindingContext = new SubscriberViewModel();
        }
    }
}
