using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructuresPart1.Prolems

{
    public static class Exercises
    {

        //2- Given an array of integers, count the number of unique pairs of integers that have difference k.Input: [1, 7, 5, 9, 2, 12, 3] K= 2 Output: 4 We have four pairs with difference 2: (1, 3), (3, 5), (5, 7), (7, 9). Note that we only want the number of these pairs, not the pairs themselves.

        public static int UniquePairOfIntegers(int[] arr, int k)
        {
            List<int[]> lst = new List<int[]>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr.Contains(arr[i] + k))
                    lst.Add(new int[] { arr[i], arr[i] + k });
                if (arr.Contains(arr[i] - k))
                    lst.Add(new int[] { arr[i], Math.Abs(arr[i] - k) });
            }
            return lst.Count/2;
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

        // 1- Find the most repeated element in an array of integers. What is the time complexity of this method? (A variation of this exercise is finding the most repeated word in a sentence. The algorithm is the same. Here we use an array of numbers for simplicity.)  Input: [1, 2, 2, 3, 3, 3, 4] Output: 3
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
            var keysList = new List<int>(keyValuePairs.Keys);
            var valuesList = new List<int>(keyValuePairs.Values);

            return keysList[valuesList.IndexOf(valuesList.Max())];
        }

    }
}
