using System.ComponentModel;
using Xamarin.Forms;
using NotesApp.MobileClient.ViewModels;

namespace NotesApp.MobileClient.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}