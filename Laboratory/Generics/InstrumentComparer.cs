using System;
using System.Collections.Generic;

namespace Generics
{
    class InstrumentComparer : IEqualityComparer<Instrument>
    {
        public bool Equals(Instrument x, Instrument y)
        {
            return String.Equals(x.Name, y.Name);
        }

        public int GetHashCode(Instrument obj)
        {
            return obj.Name.GetHashCode();
        }
    }
}
