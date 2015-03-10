using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp3.LINQ
{
    public class Builder
    {
        public IEnumerable<int> BuilderIntegerSequence()
        {
            var integers = Enumerable.Range(0, 10)
                                     .Select( i => 5 + (10 *  i));

            return integers;
        }

        public IEnumerable<int> BuilderRepeatNIntegerSequence()
        {
            var integers = Enumerable.Repeat(-1, 10);
            return integers;
        }

        public IEnumerable<string> BuilderStringSequence()
        {
            var strings = Enumerable.Range(0, 10)
                                    .Select(i => ((char)('A' + i)).ToString());
            return strings;
        }

        public IEnumerable<string> BuilderRandomStringSequence()
        {
            Random rand = new Random();

            var strings = Enumerable.Range(0, 10)
                                    .Select(i => ((char)('A' + rand.Next(0, 26))).ToString());
            return strings;
        }

        public IEnumerable<int> IntersectSequences()
        {
            var seq1 = Enumerable.Range(0, 10);
            var seq2 = Enumerable.Range(0, 10)
                                 .Select(i => i * i);

            return seq1.Intersect(seq2);
        }

        public IEnumerable<int> ExceptSequences()
        {
            var seq1 = Enumerable.Range(0, 10);
            var seq2 = Enumerable.Range(0, 10)
                                 .Select(i => i * i);

            return seq1.Except(seq2);
        }

        // combine both sequences including duplicates
        public IEnumerable<int> ConcatSequences()
        {
            var seq1 = Enumerable.Range(0, 10);
            var seq2 = Enumerable.Range(0, 10)
                                 .Select(i => i * i);

            return seq1.Concat(seq2);
        }

        // combine both sequences - remove duplicates
        public IEnumerable<int> UnionSequences()
        {
            var seq1 = Enumerable.Range(0, 10);
            var seq2 = Enumerable.Range(0, 10)
                                 .Select(i => i * i);

            return seq1.Union(seq2);
        }


    }
}
