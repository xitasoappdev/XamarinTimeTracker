using System;
using System.Collections.Generic;
using System.Linq;
using GalaSoft.MvvmLight;
using XamarinTimeTracker.Model;

namespace XamarinTimeTracker
{
    public class Project : ObservableObject
    {
        public string Name { get; }

        public string Description { get; set; }

        private readonly IList<Segment> segments = new List<Segment>();
        private Segment activeSegment;

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

        private int totalTimeSpentSeconds = 0;

        public int TotalTimeSpentSeconds
        {
            get { return totalTimeSpentSeconds; }
            set
            {
                totalTimeSpentSeconds = value;
                RaisePropertyChanged(() => TotalTimeSpentSeconds);
            }
        }

        public void StopTracking(DateTime stopTime)
        {

            if (activeSegment == null)
            {
                return;
            }

            activeSegment.EndTime = stopTime;
            activeSegment = null;

            IsActive = false;
        }

        public void StartTracking(DateTime startTime)
        {

            if (activeSegment != null)
            {
                StopTracking(startTime);
            }

            activeSegment = new Segment(startTime);
            segments.Add(activeSegment);

            IsActive = true;
        }

        public void Tick(DateTime now)
        {
            TotalTimeSpentSeconds =
                (int)segments.Sum(segment =>
                    (segment.EndTime ?? now)
                    .Subtract(segment.StartTime)
                    .TotalSeconds);
        }
    }
}