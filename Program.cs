using DataStructuresPart1.HashTables;
using DataStructuresPart1.LinkedList;
using DataStructuresPart1.Queues;
using DataStructuresPart1.Stacks;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataStructuresPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 7, 5, 9, 2, 12, 3 };
            //var b = MostFrequent(arr);

            var c = UniquePairOfIntegers(arr, 2);

            // Sorted set of sorted sets

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
        static int MostFrequent(int[] arr)
        {
            // arr.ma
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

            foreach (var item in arr)
            {
                if (!keyValuePairs.ContainsKey(item))
                    keyValuePairs.Add(item, 1);

                keyValuePairs[item]++;
            }
            ArrayList ar = new ArrayList();

            var keysList = new List<int>(keyValuePairs.Keys);
            var valuesList = new List<int>(keyValuePairs.Values);

            return keysList[valuesList.IndexOf(valuesList.Max())];
        }
        static int UniquePairOfIntegers(int[] arr, int k)
        {
            SortedSet<SortedSet<int>> sortedSet = new SortedSet<SortedSet<int>>();

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (Math.Abs(i - j) == k)
                        sortedSet.Add(new SortedSet<int>(new int[] { i, j }));
                }
            }
            return sortedSet.Count;
        }
    }
}
