using System;

using Xamarin.Forms;

namespace TaskyApp
{
	public class Login1 : ContentPage
	{
		public Login1 ()
		{
			var layout = new StackLayout ();

			var NameLabel = new Label{ };
			var NameEntry = new Entry {Placeholder = "Name", HorizontalOptions= LayoutOptions.FillAndExpand};


			var StreetLevel = new Label{ };
			var StreetEntry = new Entry {Placeholder = "Street"};


			var CityLevel = new Label{ };
			var CityEntry = new Entry {Placeholder = "City"};


			var ZipLevel = new Label{ };
			var ZipEntry = new Entry {Placeholder = "ZIP"};


			layout.Children.Add (NameLabel);
			layout.Children.Add (NameEntry);
			layout.Children.Add (StreetLevel);
			layout.Children.Add (StreetEntry);
			layout.Children.Add (CityLevel);
			layout.Children.Add (CityEntry);
			layout.Children.Add (ZipLevel);
			layout.Children.Add (ZipEntry);

			Content = layout;

		}
	}
}


