using System;

using Xamarin.Forms;

namespace TaskyApp
{
	public class ListViewTask : ContentPage
	{
		public ListViewTask ()
		{
			Padding = new Thickness (0, Device.OnPlatform (20, 0, 0), 0, 0);
			var listView = new ListView ();
			listView.ItemsSource = Task.GetTaskList ();
			listView.ItemTemplate = new DataTemplate (typeof(TaskCellTemplate));

			var createTask = new Button()
			{ WidthRequest = 50, HeightRequest = 80, BackgroundColor = Color.FromHex("77D065"), Text = "Create New Task", 
				FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)) 
			};
			createTask.Clicked += CreateProductOnClicked;
		

			
		
		//	listView.ItemSelected += async (sender, e) => {
		//		await DisplayAlert ("Tapped!", e.SelectedItem + " was tapped.", "OK");
		//	};

			listView.ItemSelected += async (sender, e) => 
			{
				var todoItem = (Task)e.SelectedItem;
				var todoPage = new TaskPage (todoItem); // so the new page shows correct data
				await Navigation.PushAsync (todoPage);
			};


			Content = new StackLayout {
				Children = {
					listView,
					createTask
				}
			};

		

   }

		async void CreateProductOnClicked(object sender, EventArgs eventArgs)
		{
			await Navigation.PushAsync(new TaskCreation());
		}

}
}
