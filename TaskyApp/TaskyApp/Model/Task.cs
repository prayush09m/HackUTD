using System;
using System.Collections.Generic;

namespace TaskyApp
{
	public class Task
	{

		public Task ()
		{


		}
		public string Name{get; set;}
		public string Location{ get; set; }
		public string Duration{ get; set; }
		public int Points { get; set; }
		public string Description { get; set; }

		public override string ToString ()
		{
			return Name;
		}

		public static List<Task> GetTaskList()
		{
			var TaskList = new List<Task> ();

			TaskList.Add (new Task {
				Name = "Task1",
				Location = "Location1",
				Duration = "Duration1",
				Points = 50,
				Description= "fkajskfjskljdfjskld"
			});

			TaskList.Add (new Task {
				Name = "Task2",
				Location = "Location2",
				Duration = "Duration2",
				Points = 100,
				Description= "fkajskfjskljdfjskld"
			});


			TaskList.Add (new Task {
				Name = "Task3",
				Location = "Location3",
				Duration = "Duration3",
				Points = 20,
				Description= "fkajskfjskljdfjskld"
			});


			return TaskList;

	}
}
}






















