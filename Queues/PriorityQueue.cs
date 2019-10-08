using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresPart1.Queues
{
    public class PriorityQueue
    {
        private int[] arr = new int[5];
        private int Count = default;
        private int frontPointer = default;

        public void Enqueue(int item)
        {
            if (Count == arr.Length)
                throw new InvalidOperationException($"Queue is full.");

            if (Count == 0)
                arr[Count] = item;
            else
            {
                for (int i = Count - 1; i >= -1; i--)
                {
                    if (i >= 0 && arr[i] > item)
                        arr[i + 1] = arr[i];
                    else
                    {
                        arr[i + 1] = item;
                        break;
                    }
                }
            }
            Count++;
        }

        public int Dequeue()
        {
            if (frontPointer < arr.Length && Count != 0)
                return arr[frontPointer++];
            throw new InvalidOperationException();
        }
    }
}
