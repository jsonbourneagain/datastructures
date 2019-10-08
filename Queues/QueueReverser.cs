using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresPart1.Queues
{
    public class QueueReverser
    {
        // 1- Given an integer K and a queue of integers, write code to reverse the order of the first K elements of the queue.
        //    Input:  Q = [10, 20, 30, 40, 50], K = 3
        //    Output: Q = [30, 20, 10, 40, 50]

        public Queue<int> ReverseQ(Queue<int> queue, int k)
        {
            if (queue.Count == 0 || k <= 0 || k > queue.Count)
                throw new InvalidOperationException();

            Stack<int> tempStack = new Stack<int>();
            Queue<int> tempQ = new Queue<int>();
            var count = queue.Count;

            for (int i = 0; i < k; i++)
            {
                tempStack.Push(queue.Dequeue());
            }
            for (int j = k; j < count; j++)
            {
                tempQ.Enqueue(queue.Dequeue());
            }
            for (int l = 0; l < k; l++)
            {
                queue.Enqueue(tempStack.Pop());
            }
            for (int m = k; m < count; m++)
            {
                queue.Enqueue(tempQ.Dequeue());
            }
            return queue;
        }
    }
}
