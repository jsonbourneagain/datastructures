using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresPart1.Queues
{
    public class StackQueue
    {
        // Implement a Queue using a Stack
        private Stack<int> enqStack = new Stack<int>();
        private Stack<int> deqStack = new Stack<int>();

        public void Enqueue(int item)
        {
            if (deqStack.Count > 0)
            {
                var lenDq = deqStack.Count;
                for (int i = 0; i < lenDq; i++)
                    enqStack.Push(deqStack.Pop());
            }
            enqStack.Push(item);
            var len = enqStack.Count;
            for (int i = 0; i < len; i++)
            {
                deqStack.Push(enqStack.Pop());
            }
        }
        public int Dequeue()
        {
            var retVal = deqStack.Pop();

            var len = deqStack.Count;
            for (int i = 0; i < len; i++)
                enqStack.Push(deqStack.Pop());

            return retVal;
        }
        public int Peek() => deqStack.Peek();

    }
}
