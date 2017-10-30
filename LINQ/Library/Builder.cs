using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Builder
    {
        public IEnumerable<int> BuildIntegerSequence()
        {
            //var integers = Enumerable.Range(0, 10)
            //                .Select(i=> 5 + (10*i));

            var integers = Enumerable.Repeat(-1, 10);
            return integers;
        }

        public IEnumerable<string> BuildStringSequence()
        {
            Random rand = new Random();
            var strings = Enumerable.Range(0, 10)
                            .Select(i => ((char)('A' + rand.Next(0,26))).ToString());
            return strings;
        }

        public IEnumerable<int> CompareSequence()
        {
            var seq1 = Enumerable.Range(0, 10);
            var seq2 = Enumerable.Range(0, 10)
                .Select(i => i * i);

            //return seq1.Intersect(seq2);
            //return seq1.Except(seq2);
            //return seq1.Concat(seq2).Distinct();
            return seq1.Union(seq2);
        }
    }
}
