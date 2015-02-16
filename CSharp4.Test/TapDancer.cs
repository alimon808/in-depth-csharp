using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp4.Test
{
    public class TapDancer : Dancer
    {

        public TapDancer() : base("My tap dancer")
        {

        }
        public override void Dance()
        {
            Console.WriteLine("Drip drip");
        }
    }
}
