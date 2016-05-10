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
			BindingContext = App.Locator.Start;

			ProjectsListView.ItemSelected += (sender, e) => {
				ProjectsListView.SelectedItem = null;
			};
		}
	}
}

