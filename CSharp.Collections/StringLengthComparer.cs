using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Collections
{
    public class StringLengthComparer : IComparer<string>
    {

        public int Compare(string x, string y)
        {
            return x.Length.CompareTo(y.Length);
        }
    }
}
