﻿using System;
using System.Collections.Generic;
using NotesApp.MobileClient.ViewModels;
using NotesApp.MobileClient.Views;
using Xamarin.Forms;

namespace NotesApp.MobileClient
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
