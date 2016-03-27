using System;
using Xamarin.Forms;
using System.Linq;

namespace TaskyApp
{
	public class Login : ContentPage
	{
		public Login ()
		{
			Title = "HackathonApp";

			var layout = new StackLayout ();

			var UserNameLabel = new Label{ };
			var UserNameEntry = new Entry {Placeholder = "Username", HorizontalOptions= LayoutOptions.FillAndExpand};


			var PasswordLevel = new Label{ };
			var PasswordEntry = new Entry {Placeholder = "Password"};

			Button button = new Button
			{
				Text = "LogIn!",
				Font = Font.SystemFontOfSize(NamedSize.Large),
			
			};


			layout.Children.Add (UserNameLabel);
			layout.Children.Add (UserNameEntry);
			layout.Children.Add (PasswordLevel);
			layout.Children.Add (PasswordEntry);
			layout.Children.Add (button);


			Content = layout;

		
		//	button.Clicked +=(o,e) => 
		//	{
		//		Navigation.PushAsync( new TaskPage(Task.GetTaskList().First()));
		//	};

			//button.Clicked +=(o,e) => 
			//{
			//	Navigation.PushAsync( new TaskMasterDetail());
			//};

			button.Clicked +=(o,e) => 
			{
				Navigation.PushAsync( new ListViewTask());
			};

		}

	}
}

