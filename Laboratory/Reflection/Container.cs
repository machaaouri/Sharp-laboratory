using System;
using System.Collections.Generic;
using System.Linq;

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
                return CreateInstance(destinationType);
            }
            else if(sourceType.IsGenericType &&
                    _map.ContainsKey(sourceType.GetGenericTypeDefinition()))
            {
                var destination = _map[sourceType.GetGenericTypeDefinition()];
                var closedDestination = destination.MakeGenericType(sourceType.GenericTypeArguments);
                return CreateInstance(closedDestination);
            }
            else if(!sourceType.IsAbstract)
            {
                return CreateInstance(sourceType);
            }
            else
            {
                throw new InvalidOperationException("Could not resolve " + sourceType.FullName);
            }
        }

        private object CreateInstance(Type destinationType)
        {
            //using reflection , return a list of constructors
            //Order them by number of params and get the first constructor's params list

            var parameters = destinationType.GetConstructors()
                                      .OrderByDescending(c => c.GetParameters().Count())
                                      .First()
                                      .GetParameters()
                                      .Select(p => Resolve(p.ParameterType))
                                      .ToArray();

            return Activator.CreateInstance(destinationType,parameters);
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
