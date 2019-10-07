using DataStructuresPart1.LinkedList;
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
            Queue<int> que = new Queue<int>();
            que.Enqueue(5);
            que.Enqueue(6);
            que.Enqueue(7);
            que.Enqueue(9);

            que = ReverseQueue(que);

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
