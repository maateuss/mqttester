using System;
using System.Collections.Generic;
using MQTTester.Views;
using Xamarin.Forms;

namespace MQTTester
{
    public partial class AppShell : Shell
    {
        Dictionary<string, Type> routes = new Dictionary<string, Type>();

        public Dictionary<string, Type> Routes { get { return routes; } }

        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();

        }

        void RegisterRoutes()
        {
            routes.Add("subscriberview", typeof(SubscriberView));
            routes.Add("publisherview", typeof(PublisherView));

            foreach (var item in routes)
            {
                Routing.RegisterRoute(item.Key, item.Value);
            }
        }
    }
}
