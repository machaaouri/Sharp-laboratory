using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Generics
{
    public static class BufferExtensions
    {

        public static void Dump<T>( this IBuffer<T> buffer)
        {
            foreach(var item in buffer)
            {
                Console.WriteLine(item);
            }
        }
        public static IEnumerable<Toutput> AsEnumerableOf<T,Toutput>
            (this IBuffer<T> buffer)
        {
            var converter = TypeDescriptor.GetConverter(typeof(T));
            foreach (var item in buffer)
            {
                Toutput result = (Toutput)converter.ConvertTo(item, typeof(Toutput));
                yield return result;
            }
        }
    }
}
