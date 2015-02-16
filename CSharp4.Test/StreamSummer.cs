using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharp4.Test
{
    public class StreamSummer
    {
        public int Sum(Stream stream)
        {
            int total = 0;
            int value;
            while ((value = stream.ReadByte()) != -1)
            {
                total += value;
            }
            return total;
        }
    }
}
