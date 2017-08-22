
namespace DataStructures
{
    /*
     * Implement a MyQueue class which implements a queue using two stacks 
    */
    class MyQueue<T>
    {

        System.Collections.Generic.Stack<T> stackIn, stackOut;

        public MyQueue()
        {
            stackIn = new System.Collections.Generic.Stack<T>();
            stackOut = new System.Collections.Generic.Stack<T>();
        }

        public void add(T value)
        {
            stackIn.Push(value);
        }

        public T peek()
        {
            if (stackOut.Count != 0) return stackOut.Peek();
            while (stackIn.Count > 0) stackOut.Push(stackIn.Pop());

            return stackOut.Peek();
        }

        public T remove()
        {
            if (stackOut.Count != 0) return stackOut.Pop();
            while (stackIn.Count > 0) stackOut.Push(stackIn.Pop());

            return stackOut.Pop();
        }
    }
}
