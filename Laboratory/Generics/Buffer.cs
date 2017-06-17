﻿using System.Collections.Generic;

namespace Generics
{
    public class Buffer<T> : IBuffer<T>
    {
        protected Queue<T> _queue = new Queue<T>(); 

        public virtual bool IsEmpty
        {
            get { return _queue.Count == 0; }
        }

        public virtual void Write(T value)
        {
            _queue.Enqueue(value);
        }

        public virtual T Read()
        {
            return _queue.Dequeue();
        }

        
    }
}
