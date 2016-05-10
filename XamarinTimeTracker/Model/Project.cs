using System;
namespace XamarinTimeTracker
{
	public class Project
	{
		private string _title;
		public string Title
		{
			get { return _title; }
			set { _title = value; }
		}

		private string _description;
		public string Description
		{ 
			get { return _description; }
			set { _description = value; }
		}

		public Project(string title, string description)
		{
			Title = title;
			Description = description;
		}
	}
}