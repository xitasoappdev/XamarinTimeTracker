using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinTimeTracker.Model
{
    class Segment
    {
        public DateTime StartTime { get; }

        public DateTime? EndTime { get; internal set; }

        public Segment(DateTime startTime)
        {
            StartTime = startTime;
        }
    }
}
