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
        private int lastPointer = default;

        public void Enqueue(int item)
        {
            if (IsFull())
                throw new Exception($"Queue is full.");

            arrQu[lastPointer] = item;
            lastPointer = (lastPointer + 1) % arrQu.Length;
            Count++;
        }
        public int Dequeue()
        {
            if (IsEmpty())
            {
                ResetPointers();
                throw new Exception($"Queue is empty.");
            }
            
            var temp = arrQu[firstPointer];
            arrQu[firstPointer] = 0;
            Count--;
            firstPointer = (firstPointer + 1) % arrQu.Length;
            return temp;
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
            lastPointer = 0;
        }

    }
}
