using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresPart1.Stacks
{
    public class Stack
    {
        private int[] arr = new int[10];
        private int Count = default;

        // Push
        public void Push(int item)
        {
            if (Count == arr.Length)
            {
                var tempArr = new int[2 * Count];

                for (int i = 0; i < arr.Length; i++)
                {
                    tempArr[i] = arr[i];
                }
                arr = tempArr;

                arr[Count++] = item;
            }
            else
                arr[Count++] = item;
        }

        // Pop
        public int Pop()
        {
            if (Count > 0)
            {
                var temp = arr[Count - 1];
                arr[Count - 1] = -1; // For the sake of simplicity I'm using -1 to say that, place is vacant if it has -1
                Count--;
                return temp;
            }
            else
                throw new InvalidOperationException($"Stack is empty.");
        }

        // Peek
        public int Peek()
        {
            if (Count > 0)
                return arr[Count - 1];
            else
                throw new InvalidOperationException($"Stack is empty.");
        }

        public bool IsEmpty() => Count == 0;
    }
}
