using System;

using Xamarin.Forms;
using System.Linq;

namespace TaskyApp
{
	public class TaskMasterDetail : MasterDetailPage
	{
		public TaskMasterDetail ()
		{
			
				var listView = new ListView ();
				listView.ItemsSource = Task.GetTaskList();

				listView.ItemSelected += (sender, e) => 
				{
					if(e.SelectedItem != null)
					{
					Detail = new TaskPage(e.SelectedItem as Task);

						//hide the master page
						IsPresented = false;
					}
				};

				Master = new ContentPage {
					Title = "Tasks",
					Content = listView
				};

			Detail = new TaskPage(Task.GetTaskList().First ());
			}
		}

		
	
}


