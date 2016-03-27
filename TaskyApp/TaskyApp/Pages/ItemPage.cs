using System;

using Xamarin.Forms;

namespace TaskyApp
{
	public class ItemPage : ContentPage
	{
		public ItemPage (Task t)
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


