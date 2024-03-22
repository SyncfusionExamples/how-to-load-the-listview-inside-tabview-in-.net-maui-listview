using System;
using System.Collections.Generic;


namespace MauiListView
{
    public partial class InboxPage : ContentView
    {
        public InboxPage()
        {
            InitializeComponent();
            this.BindingContext = new ListViewInboxInfoRepository();
        }
    }
}
