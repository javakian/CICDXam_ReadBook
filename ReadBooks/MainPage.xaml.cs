﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ReadBooks
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void AddNewBook_Clicked(object sender, System.EventArgs e)
        {
            AppCenterHelper.TrackEvent("add_book_intent");
            await Navigation.PushAsync(new NewBookPage());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var books = Book.ReadBooks();
            booksListView.ItemsSource = books;
        }
    }
}
