using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Framework;

namespace CSharp4.Linq
{
    public class Worker
    {
        public void DoWork()
        {
            var task = new TaskScheduler(new AccountSynchronizationTask(), 
                                         runEvery: 2.Minutes(), 
                                         expiration: 3.Days());
        }
    }

    public static class TimeSpanExtensions
    {
        public static TimeSpan Minutes(this int value)
        {
            return new TimeSpan(0, 0, value, 0);
        }

        public static TimeSpan Days(this int value)
        {
            return new TimeSpan(value, 0, 0, 0);
        }
    }

    public class AccountSynchronizationTask : ITask
    {
        public IBuildEngine BuildEngine
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool Execute()
        {
            throw new NotImplementedException();
        }

        public ITaskHost HostObject
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }

}
