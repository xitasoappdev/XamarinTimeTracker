using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinTimeTracker
{
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
            var viewModel = App.Locator.Start;
            BindingContext = viewModel;

            Projects.ItemTapped += (sender, e) =>
            {
                viewModel.ToggleProjectCommand.Execute(e.Item);
                Projects.SelectedItem = null;
            };
        }
    }
}

