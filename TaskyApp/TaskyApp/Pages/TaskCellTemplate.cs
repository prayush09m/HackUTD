using System;

using Xamarin.Forms;

namespace TaskyApp
{
	public class TaskCellTemplate : ViewCell
	{
		public TaskCellTemplate ()
		{

			var NameLabel = new Label
			{
				Font = Font.SystemFontOfSize (NamedSize.Medium)
					.WithAttributes (FontAttributes.Bold)

				};
			NameLabel.SetBinding(Label.TextProperty, new Binding("Name"));



			var LocationLabel = new Label
			{
				Font = Font.SystemFontOfSize (NamedSize.Micro),
				XAlign = TextAlignment.End,
				HorizontalOptions = LayoutOptions.FillAndExpand

					//.WithAttributes (FontAttributes.Bold)

			};
			LocationLabel.SetBinding(Label.TextProperty, new Binding("Location"));


			var DescriptionLabel = new Label
			{
				Font = Font.SystemFontOfSize (NamedSize.Micro),
				XAlign = TextAlignment.End,
				HorizontalOptions = LayoutOptions.FillAndExpand

					//.WithAttributes (FontAttributes.Bold)

			};
			DescriptionLabel.SetBinding(Label.TextProperty, new Binding("Description"));


			var PointsLabel = new Label
			{
				Font = Font.SystemFontOfSize (NamedSize.Micro),
				XAlign = TextAlignment.End,
				HorizontalOptions = LayoutOptions.FillAndExpand

					//.WithAttributes (FontAttributes.Bold)

			};
			PointsLabel.SetBinding(Label.TextProperty, new Binding("Points"));


			var DurationLabel = new Label
			{
				Font = Font.SystemFontOfSize (NamedSize.Micro),
				XAlign = TextAlignment.End,
				HorizontalOptions = LayoutOptions.FillAndExpand

					//.WithAttributes (FontAttributes.Bold)

			};
			DurationLabel.SetBinding(Label.TextProperty, new Binding("Duration"));


			View = new StackLayout {

			Children = {NameLabel},

				Orientation = StackOrientation.Horizontal
			};

		}
	}
		
	
}


