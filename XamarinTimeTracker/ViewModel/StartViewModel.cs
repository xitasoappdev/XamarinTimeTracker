using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
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
        public StartViewModel()
        {
            Projects = new ObservableCollection<Project>();
        }

        private string newProjectName;

        public string NewProjectName
        {
            get { return newProjectName; }
            set { Set(() => NewProjectName, ref newProjectName, value); }
        }

        public ObservableCollection<Project> Projects
        {
            get;
            private set;
        }
    }
}