using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp4.Test
{
    public class StartAndStopper
    {
        public void StartAndStop(IControllable controllable)
        {
            controllable.Start();
            controllable.Stop();
        }
    }
}
