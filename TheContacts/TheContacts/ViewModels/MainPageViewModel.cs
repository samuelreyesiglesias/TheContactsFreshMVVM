using Bogus;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TheContacts.Models;

namespace TheContacts.ViewModels
{
    public class MainPageViewModel
    {
        public ObservableCollection<Contact> Contacts { get; set; }
        =new ObservableCollection<Contact>();

        public MainPageViewModel()
        {
            //Contacts = new Faker<Contact>();

        }
    }
}
