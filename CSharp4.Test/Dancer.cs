using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp4.Test
{
    public abstract class Dancer : IControllable
    {
        private readonly string name;
        
        public string Name { get { return name; } }

        protected Dancer(string name)
        {
            this.name = name;
        }
        public abstract void Dance();

        public void Start()
        {
            Console.WriteLine("Starting dancing");
            Dance();
        }
        public void Stop()
        {
            Console.WriteLine("Stopped dancing");
        }

        public void DanceTwice()
        {
            Dance();
            Dance();

        }
    }
}
