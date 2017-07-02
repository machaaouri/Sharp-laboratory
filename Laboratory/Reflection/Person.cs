using System;

namespace Reflection
{
    public class Person
    {
        string Name { get; set; }

        public void Speak<T>()
        {
            Console.WriteLine(typeof(T).Name);
        }
    }
}