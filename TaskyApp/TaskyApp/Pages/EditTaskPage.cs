using System;

using Xamarin.Forms;

namespace TaskyApp
{
	public class EditTaskPage : ContentPage
	{
		public EditTaskPage (Task task)
		{
			Title = "Edit Task";

			var NameEntry = new Entry {Placeholder = "Name", HorizontalOptions= LayoutOptions.FillAndExpand, 
				Text =task.Name};
			var LocationEntry = new Entry {Placeholder = "Location", HorizontalOptions= LayoutOptions.FillAndExpand, Text=task.Location};
			var DurationEntry = new Entry {Placeholder = "Duration", HorizontalOptions= LayoutOptions.FillAndExpand,Text=task.Duration};
			var PointsEntry = new Entry {Placeholder = "Points", HorizontalOptions= LayoutOptions.FillAndExpand ,
				Text=task.Points.ToString()};
			var DescriptionEntry = new Entry { 
				WidthRequest = 300,
				HeightRequest = 200,
				Placeholder = "Description",
				//	HorizontalOptions = LayoutOptions.Start
				HorizontalOptions= LayoutOptions.FillAndExpand,
				Text=task.Description
			};
			var editButton = new Button{Text = "SaveChanges", 
				FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Button))  };

			Content = new StackLayout {
				Children = { NameEntry, LocationEntry, DurationEntry, PointsEntry, DescriptionEntry, editButton }
			};

		}
	}
}


