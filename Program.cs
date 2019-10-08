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
            var cr = FirstNonRepeatedCharacter("a green apple");

            Console.WriteLine();
        }
        static Queue<int> ReverseQueue(Queue<int> que)
        {
            Stack<int> stack = new Stack<int>();
            var qSize = que.Count;

            for (int i = 0; i < qSize; i++)
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

        static char FirstNonRepeatedCharacter(string input)
        {
            var ar = input.Replace(" ", "");
            Dictionary<char, int> charDic = new Dictionary<char, int>();
            char retChar = ' ';
            foreach (char c in ar)
            {
                if (!charDic.ContainsKey(c))
                    charDic.Add(c, 1);
                else
                    charDic[c]++;
            }
            foreach (var c in charDic.Keys)
            {
                if (charDic[c] == 1)
                {
                    retChar = c;
                    break;
                }

            }
            return retChar;

        }
    }
}
