using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Framework;

namespace CSharp4.Linq
{
    public class TaskScheduler
    {
        public TaskScheduler()
        {

        }
        public TaskScheduler(ITask task, TimeSpan runEvery, TimeSpan expiration)
        {
            Task = task;
            Interval = runEvery;
            Expiration = expiration;
        }

        public ITask Task { get; protected set; }
        public TimeSpan Interval { get; protected set; }
        public TimeSpan Expiration { get; protected set; }

    }
}
