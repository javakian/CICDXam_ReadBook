﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ReadBooks
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        async void LoginButton_Clicked(object sender, System.EventArgs e)
        {
            throw new Exception("There was an error logging you in");
            await Navigation.PopModalAsync(true);
        }
    }
}
