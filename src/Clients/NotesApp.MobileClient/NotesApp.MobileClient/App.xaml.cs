using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using NotesApp.MobileClient.Services;
using NotesApp.MobileClient.Views;

namespace NotesApp.MobileClient
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<NoteService>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
