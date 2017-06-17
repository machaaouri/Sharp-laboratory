using System;
using System.Collections.Generic;

namespace Generics
{
    class InstrumentComparer : IEqualityComparer<Instrument>,
                               IComparer<Instrument>
    {
        public bool Equals(Instrument x, Instrument y)
        {
            return String.Equals(x.Name, y.Name);
        }

        public int GetHashCode(Instrument obj)
        {
            // two instruments with the same name will generate the same hashcode
            return obj.Name.GetHashCode();
        }

        public int Compare(Instrument x, Instrument y)
        {
            return String.Compare(x.Name, y.Name);
        }
    }
}
