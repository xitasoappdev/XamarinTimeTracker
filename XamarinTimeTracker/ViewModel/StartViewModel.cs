using System.Collections.Generic;
using GalaSoft.MvvmLight;

namespace XamarinTimeTracker.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class StartViewModel : ViewModelBase
    {
		private List<Project> _projects;
		public List<Project> Projects
		{ 
			get { return _projects; }
			set { _projects = value; }
		}

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public StartViewModel()
        {
			Projects = new List<Project> { 
				new Project("Technical project", "In this project we need to make a robot move"),
				new Project("Web project", "Node.js as server, AngularJS for frontend, ECMA-Script ftw!"),
				new Project("Mobile project", "Do some fancy stuff for iOS and Android")
			};
        }
    }
}