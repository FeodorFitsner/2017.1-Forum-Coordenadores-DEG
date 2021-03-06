﻿using ForumDEG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ForumDEG.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdministratorAddPage : ContentPage
    {
        public AdministratorAddPage()
        {
            InitializeComponent();
        }

        async void Save_Clicked(object sender, System.EventArgs e) {
			var admUser = (Administrator)BindingContext;

			// Check if there is no space in firsts characters
			admUser.Registration.Trim();

            admUser.CreatedOn = DateTime.Now;
            await App.AdministratorDatabase.SaveAdministrator(admUser);
            await Navigation.PopAsync();
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
