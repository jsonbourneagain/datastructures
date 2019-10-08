using DataStructuresPart1.LinkedList;
using DataStructuresPart1.Queues;
using DataStructuresPart1.Stacks;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(5);
            q.Enqueue(15);
            q.Enqueue(25);
            q.Enqueue(35);
            q.Enqueue(55);

            QueueReverser queueReverser = new QueueReverser();
            var rq = queueReverser.ReverseQ(q, 4);


            Console.WriteLine();
        }
        static Queue<int> ReverseQueue(Queue<int> que)
        {
            Stack<int> stack = new Stack<int>();
            var qSize = que.Count;

            for(int i =0; i < qSize; i++)
            {
                stack.Push(que.Dequeue());
            }

            var stackSize = stack.Count;

            for (int j = 0; j < stackSize; j++)
            {
                que.Enqueue(stack.Pop());
            }
            return que;
        }
    }
}
