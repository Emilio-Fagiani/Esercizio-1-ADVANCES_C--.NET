using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_1_ADVANCES_C__.NET
{
    internal class MyQueue <T>
    {
        private LinkedList<T> queue;

        public MyQueue()
        {
            queue = new LinkedList<T>();
        }

        public void Enqueue(T item)
        {
            queue.AddLast(item);
        }

        public T Dequeue() 
        {
            if (queue.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty.");
            }
            T item = queue.First.Value;
            queue.RemoveFirst();
            return item;

        }

        public T Peek()
        {
            if (queue.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty.");
            }

            return queue.First.Value;
        }
    }
}
