using System;
using System.Collections.Generic;

namespace Reflection
{
    public class Container
    {
        Dictionary<Type, Type> _map = new Dictionary<Type, Type>();

        public Containerbuilder For<TSource>()
        {
            return For(typeof(TSource));

        }
        public Containerbuilder For(Type sourceType)
        {
            return new Containerbuilder(this,sourceType);
        }

        public void Use<T>()
        {
            throw new NotImplementedException();
        }

        public TSource Resolve<TSource>()
        {
            return (TSource)Resolve(typeof(TSource));
        }

        public object Resolve(Type sourceType)
        {
            if(_map.ContainsKey(sourceType))
            {
                var destinationType = _map[sourceType];
                return Activator.CreateInstance(destinationType);
            }
            else
            {
                throw new InvalidOperationException("Could not resolve " + sourceType.FullName);
            }
        }

        public class Containerbuilder
        {
            Container _container;
            Type _sourceType;

            public Containerbuilder(Container container, Type sourceType)
            {
                _container = container;
                _sourceType = sourceType;
            }

            public Containerbuilder Use<TDestination>()
            {
                return Use(typeof(TDestination));
            }

            public Containerbuilder Use(Type destinationType)
            {
                _container._map.Add(_sourceType, destinationType);
                return this;
            }
        }
    }

    
}
