using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresPart1.Queues
{
    // Implement a Queue using an array.
    public class ArrayQueue
    {
        private int[] arrQu = new int[10];
        private int Count = default;
        private int firstPointer = default;
        private int lastdPointer = default;

        public void Enqueue(int item)
        {
            if (IsFull())
                throw new Exception($"Queue is full.");

            arrQu[lastdPointer++] = item;
            Count++;
        }
        public int Dequeue()
        {
            if (IsEmpty())
            {
                ResetPointers();
                throw new Exception($"Queue is empty.");
            }
            Count--;
            return arrQu[firstPointer++];
        }
        public int Peek()
        {
            if (IsEmpty())
                throw new Exception($"Queue is empty.");

            return arrQu[firstPointer];
        }
        public bool IsFull() => Count == arrQu.Length;
        public bool IsEmpty() => Count == 0;
        private void ResetPointers()
        {
            firstPointer = 0;
            lastdPointer = 0;
        }

    }
}
