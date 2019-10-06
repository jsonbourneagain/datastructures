using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresPart1.Stacks
{
    // Implement two stacks using one array
    public class TwoStackInAnArray
    {
        private int[] arr = new int[10];
        private int Count1 = default;
        private int Count2 = 5;

        public void Push1(int item)
        {
            if (Count1 == arr.Length / 2)
                throw new StackOverflowException($"Stack is full.");
            else
                arr[Count1++] = item;
        }
        public void Push2(int item)
        {
            if (Count2 == arr.Length)
                throw new StackOverflowException($"Stack is full.");
            else
                arr[Count2++] = item;
        }
        public int Pop1()
        {
            if (Count1 == 0)
                throw new InvalidOperationException($"Stack is empty.");
            else
                return arr[--Count1];
        }
        public int Pop2()
        {
            if (Count2 == 5)
                throw new InvalidOperationException($"Stack is empty.");
            else
                return arr[--Count2];
        }
        public bool IsEmpty1() => Count1 == 0;
        public bool IsEmpty2() => Count2 == 5;
        public bool IsFull1() => Count1 == 5;
        public bool IsFull2() => Count2 == 10;

    }
}
