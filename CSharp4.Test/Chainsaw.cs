using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp4.Test
{
    public class Chainsaw : IControllable
    {
        public void Start()
        {
            Console.WriteLine("Brrrrm");
        }

        public void Stop()
        {
            Console.WriteLine("Thudder der der");
        }
    }
}
