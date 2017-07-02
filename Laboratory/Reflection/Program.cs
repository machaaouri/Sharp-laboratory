using System;
using System.Collections.Generic;

namespace Reflection
{

    class Program
    {
        static void Main(string[] args)
        {
            var personList = createCollection(typeof(List<>),typeof(Person));
            // outputs (List'1) this is what c# complier produces to be compliant with the CLS
            Console.WriteLine(personList.GetType().Name);

            // get the generic arguments that was used to construct the returned type
            var genericArgumentsargs = personList.GetType().GetGenericArguments();
            foreach (var item in genericArgumentsargs)
            {
                Console.WriteLine("[{0}]",item.Name);
            }

            Console.ReadKey();
                
        }

        private static object createCollection(Type collectionType,Type itemType)
        {
            //transform the unbound type to a closed type
            var closedType = collectionType.MakeGenericType(itemType);
            // Activator has a mthod that takes a type in param and create 
            // and object instance of that type
            return Activator.CreateInstance(closedType);
        }
    }
}
