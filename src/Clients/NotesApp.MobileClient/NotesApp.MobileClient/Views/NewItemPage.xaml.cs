using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using NotesApp.MobileClient.Models;
using NotesApp.MobileClient.ViewModels;

namespace NotesApp.MobileClient.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Note Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}