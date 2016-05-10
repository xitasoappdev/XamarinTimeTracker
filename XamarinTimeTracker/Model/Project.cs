using System;
using GalaSoft.MvvmLight;

namespace XamarinTimeTracker
{
    public class Project : ObservableObject
    {
        public string Name { get; }

        public string Description { get; set; }

        public Project(string name, string description)
        {
            Name = name;
            Description = description;
        }

        private bool isActive = false;

        public bool IsActive
        {
            get { return isActive; }
            set
            {
                isActive = value;
                RaisePropertyChanged(() => IsActive);
            }
        }
    }
}