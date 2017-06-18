using System;

namespace Generics
{

    public class CircularBuffer<T> : Buffer<T>
    {
        int _capacity;

        public CircularBuffer(int capacity = 5)
        {
            _capacity = capacity;
        }

        public override void Write(T value)
        {
            base.Write(value);
            if(_queue.Count > _capacity)
            {
                var discard = _queue.Dequeue();
                OnItemDiscarded(discard, value);
            }
        }

        private void OnItemDiscarded(T discard, T value)
        {
            if(ItemDiscarded != null)
            {
                var args = new DiscardedEventArgs<T>(discard, value);
                ItemDiscarded(this, args);
            }
        }

        public event EventHandler<DiscardedEventArgs<T>> ItemDiscarded;

        public bool IsFull {  get { return _queue.Count == 0; } }
        public int Count { get { return _queue.Count; } }
    }

    public class DiscardedEventArgs<T> : EventArgs
    {
        public DiscardedEventArgs(T discarded,T newItem)
        {
            ItemDiscarded = discarded;
            NewItem = newItem;
        }

        public T ItemDiscarded { get; set; }
        public T NewItem { get; set; }
    }
}
