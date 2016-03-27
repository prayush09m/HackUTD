using System;

using Xamarin.Forms;

namespace TaskyApp
{
	public class TaskCreation : ContentPage
	{
		public TaskCreation ()
		{

			Title = "Create Task";

			var NameEntry = new Entry {Placeholder = "Name", HorizontalOptions= LayoutOptions.FillAndExpand};
			var LocationEntry = new Entry {Placeholder = "Location", HorizontalOptions= LayoutOptions.FillAndExpand};
			var DurationEntry = new Entry {Placeholder = "Duration", HorizontalOptions= LayoutOptions.FillAndExpand};
			var PointsEntry = new Entry {Placeholder = "Points", HorizontalOptions= LayoutOptions.FillAndExpand};
			var DescriptionEntry = new Entry { 
			WidthRequest = 300,
				HeightRequest = 200,
				Placeholder = "Description",
			//	HorizontalOptions = LayoutOptions.Start
				HorizontalOptions= LayoutOptions.FillAndExpand
			};

			Button button = new Button
			{
				Text = "Create!",
				Font = Font.SystemFontOfSize(NamedSize.Small),

			};

			Content = new StackLayout
			{
				Children= {NameEntry,LocationEntry,DurationEntry,PointsEntry, DescriptionEntry,button}

			};


		}
	}
}


