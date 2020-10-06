using System;
using System.Collections.Generic;
using MQTTester.ViewModels;
using Xamarin.Forms;

namespace MQTTester.Views
{
    public partial class PublisherView : ContentPage
    {
        private PublisherViewModel viewModel;

        public PublisherView()
        {
            InitializeComponent();
            viewModel = new PublisherViewModel();
            BindingContext = viewModel;
        }
    }
}
