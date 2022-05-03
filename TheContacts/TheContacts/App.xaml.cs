using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TheContacts.View;
using TheContacts.Views;

namespace TheContacts
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ContactDetails();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
