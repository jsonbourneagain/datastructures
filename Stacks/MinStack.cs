using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresPart1.Stacks
{
    public class MinStack
    {
        // Design a stack in such way that it gives you the minimum stored value in constant time i.e. O(1)
        private int[] arr = new int[10];
        private int Count = default;
        private int CountMin = 5;
        private int Min = default;

        public void Push(int item)
        {
            if (Count == arr.Length / 2)
                throw new StackOverflowException($"Stack is full.");
            else
            {
                if (Count == 0)
                    Min = item;

                if (item < Min)
                {
                    Min = item;
                    PushMin(Min);
                }
                arr[Count++] = item;
            }
        }
        private void PushMin(int item)
        {
            if (CountMin == arr.Length)
                throw new StackOverflowException($"Min Stack is full.");
            else
                arr[CountMin++] = item;
        }
        public int Pop()
        {
            if (Count == 0)
                throw new InvalidOperationException($"Stack is empty.");
            else
            {
                var temp = arr[--Count];
                if (temp == PeekMin())
                    PopMin();
            }
            return arr[--Count];
        }
        private int PopMin()
        {
            if (CountMin == 5)
                throw new InvalidOperationException($"Min Stack is empty.");
            else
                return arr[--CountMin];
        }
        private int PeekMin()
        {
            if (CountMin > 5)
                return arr[CountMin - 1];
            else if (CountMin == 5)
                return arr[CountMin];
            else
                throw new InvalidOperationException($"Stack is empty.");
        }
        public int StackMin() => PeekMin();
        public bool IsEmpty() => Count == 0;
        private bool IsMinEmpty() => CountMin == 5;
        public bool IsFull() => Count == 5;
        private bool IsMinFull() => CountMin == 10;

    }
}
