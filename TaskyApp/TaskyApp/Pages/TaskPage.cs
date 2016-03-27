using System;

using Xamarin.Forms;

namespace TaskyApp
{
	public class TaskPage : ContentPage
	{
		public TaskPage (Task task)
		{
			Padding = new Thickness (10, Device.OnPlatform (20, 0, 0), 10, 0);
			BackgroundColor = Color.Yellow;



			var NameLabel = new Label {
				Text = "Name:" +task.Name,
				Font = Font.SystemFontOfSize (NamedSize.Small)
			};

			var descriptionLabel = new Label {
				Text = "Description:"+task.Description,
				Font = Font.SystemFontOfSize (NamedSize.Medium)
			};

			var PointsLabel = new Label {
				Text = "Points:" +task.Points,
				Font = Font.SystemFontOfSize (NamedSize.Medium)
			};

			var LocationLabel = new Label {
				Text = "Location: "+ task.Location,
				Font = Font.SystemFontOfSize (NamedSize.Medium)
			};
			var DurationLabel = new Label {
				Text = "Duration:" +task.Duration,
				Font = Font.SystemFontOfSize (NamedSize.Medium)
			};

			var DeleteButton = new Button {
				Text = "Delete",
				BackgroundColor = Color.Red };
		

			var EditButton = new Button {
				Text = "Edit",
				BackgroundColor = Color.Red };
			

			Content = new ScrollView {
				Content = new StackLayout {
					Spacing = 10,
					Children = { NameLabel, descriptionLabel, PointsLabel, LocationLabel, DurationLabel,DeleteButton, EditButton }
				}
			};

			EditButton.Clicked +=(o,e) => 
			{
				Navigation.PushAsync( new EditTaskPage(task));
			};
		}
	}
		
	
}


