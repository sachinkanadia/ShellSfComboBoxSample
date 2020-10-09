using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
namespace ShellSfComboBoxSample.ComboBoxSample
{
    public class ComboBoxViewModel
    {
        public ComboBoxViewModel()
        {
            AppearingCommand = new Command(OnAppearing);
        }

        public ICommand AppearingCommand { get; private set; }
        private void OnAppearing()
        {
            Fruits.Clear();
            Fruits.Add("Strawberry");
            Fruits.Add("Apple");
            Fruits.Add("Banana");
            Fruits.Add("Orange");
        }

        public ObservableCollection<string> Fruits { get; private set; } = new ObservableCollection<string>();

        public string SelectedFruit
        {
            get;
            set;
        }
    }
}
