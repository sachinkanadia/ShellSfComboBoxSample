using System;
using System.Windows.Input;
using ShellSfComboBoxSample.ComboBoxSample;
using Xamarin.Essentials;
using Xamarin.Forms;
namespace ShellSfComboBoxSample.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamain-quickstart"));
            OpenComboBoxPageCommand = new Command(async() =>
            {
                await Shell.Current.GoToAsync(nameof(ComboBoxPage), true);
            });
        }

        public ICommand OpenWebCommand { get; }

        public ICommand OpenComboBoxPageCommand { get; }
    }
}