using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using XamarinTimeTracker.Model;

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

        private readonly ITimer timer;
        private Project currentProject;

        public StartViewModel(ITimer projectTimer)
        {
            timer = projectTimer;
 
            Projects = new ObservableCollection<Project>();

            timer.Start(TimeSpan.FromSeconds(1));
            timer.Elapsed += (sender, tickUtc) => currentProject?.Tick(tickUtc);
        }

        private string newProjectName;

        public string NewProjectName
        {
            get { return newProjectName; }
            set { Set(() => NewProjectName, ref newProjectName, value); }
        }


        public RelayCommand AddNewProjectCommand => new RelayCommand(updateProjectList);

        public RelayCommand<Project> ToggleProjectCommand
        {
            get
            {
                return new RelayCommand<Project>(toggleProject);
            }
        }

        private void updateProjectList()
        {
            if (string.IsNullOrWhiteSpace(NewProjectName))
                return;

            Projects.Add(new Project(NewProjectName, null));
            NewProjectName = "";
        }
    

        public ObservableCollection<Project> Projects
        {
            get;
        }

        private void toggleProject(Project project)
        {
            if (currentProject == project)
            {
                currentProject.StopTracking(timer.Now);
                currentProject = null;
            }
            else if (currentProject == null)
            {
                currentProject = project;
                currentProject.StartTracking(timer.Now);
            }
            else {
                currentProject.StopTracking(timer.Now);
                currentProject = project;
                currentProject.StartTracking(timer.Now);
            }
        }
    }
}