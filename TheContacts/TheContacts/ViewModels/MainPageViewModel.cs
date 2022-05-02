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
            var contacts = new Faker<Contact>()
                .RuleFor(o => o.Nombre, f => f.Name.FullName())
                .RuleFor(o => o.Telefono, f => f.Phone.PhoneNumber())
                .Generate(25);

            Contacts = new ObservableCollection<Contact>(contacts);



        }
    }
}
