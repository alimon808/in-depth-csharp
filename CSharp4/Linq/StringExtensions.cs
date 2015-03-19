using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp4.Linq
{
    public static class StringExtensions
    {
        // simple validation
        public static bool IsValidPostalCode(this string value)
        {
            return value.Length == 5 || value.Length == 9;
        }
    }
}
