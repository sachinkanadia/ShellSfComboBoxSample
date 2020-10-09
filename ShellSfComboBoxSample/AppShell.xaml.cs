using System;
using System.Collections.Generic;
using ShellSfComboBoxSample.ComboBoxSample;
using ShellSfComboBoxSample.ViewModels;
using ShellSfComboBoxSample.Views;
using Xamarin.Forms;

namespace ShellSfComboBoxSample
{
    public class ViewFactory<T> : RouteFactory
        where T : ContentPage, new()
    {
        private static T _Page;

        public override Element GetOrCreate()
        {
            if (_Page == null)
                _Page = new T();
            return _Page;
        }
    }

    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(ComboBoxPage), new ViewFactory<ComboBoxPage>());
        }
    }
}
