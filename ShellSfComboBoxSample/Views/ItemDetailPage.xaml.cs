using System.ComponentModel;
using Xamarin.Forms;
using ShellSfComboBoxSample.ViewModels;

namespace ShellSfComboBoxSample.Views
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