using System;
using System.Collections.Generic;

namespace MauiListView
{
    public partial class ContactPage : ContentView
    {
        public ContactPage()
        {
            InitializeComponent();
            this.BindingContext = new ContactsRepository();
        }
    }
}
