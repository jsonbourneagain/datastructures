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
            // Implement a queue using 
            QueueWithLinkedList queueWithLinkedList = new QueueWithLinkedList();
            queueWithLinkedList.Enqueue(5);
            queueWithLinkedList.Enqueue(15);
            queueWithLinkedList.Enqueue(35);

            var a = queueWithLinkedList.Dequeue();
            var b = queueWithLinkedList.Peek();

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
