using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace MauiListView
{
    public partial class BookPage : ContentView
    {
        BookInfoRepository bookInfoRepository;
        public BookPage()
        {
            InitializeComponent();
            bookInfoRepository = new BookInfoRepository();  
            this.BindingContext = bookInfoRepository;
        }
    }
}
