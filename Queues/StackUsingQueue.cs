using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresPart1.Queues
{
    public class StackUsingQueue
    {
        // Build a stack using 2 queue
        private Queue<int> pushQ;
        private Queue<int> popQ;

        public StackUsingQueue()
        {
            pushQ = new Queue<int>();
            popQ = new Queue<int>();
        }
        public void Push(int item)
        {
            var popQCount = popQ.Count;
            while (popQ.Count != 0)
            {
                pushQ.Enqueue(popQ.Dequeue());
            }
            pushQ.Enqueue(item);
        }
        public int Pop()
        {
            if (pushQ.Count == 0)
                throw new InvalidOperationException();

            var pushQCount = pushQ.Count;
            for (int i = 0; i < pushQCount - 1; i++)
            {
                popQ.Enqueue(pushQ.Dequeue());
            }

            var retVal = pushQ.Dequeue();

            var popQCount = popQ.Count;
            for (int i = 0; i < popQCount; i++)
            {
                pushQ.Enqueue(popQ.Dequeue());
            }

            return retVal;
        }
    }
}
