using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinTimeTracker.Model
{
    interface ITimer
    {
        DateTime Now { get; }

        void Start(TimeSpan interval);

        event EventHandler<DateTime> Elapsed;
    }
}
