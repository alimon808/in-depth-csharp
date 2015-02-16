using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp4.Test
{
    public class DerivedClass : BaseClass
    {
        public DerivedClass()
            : base("derived default")
        {

        }

        public DerivedClass(string localName)
            : base("derived " + localName)
        {

        }
        public override int CalculateResult(int x)
        {
            return x / 2;
        }
        public int Quadruple(int x)
        {
            return x * 4;
        }
    }
}
