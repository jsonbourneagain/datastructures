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
            // Min stack test cases

            MinStack minStack = new MinStack();
            minStack.Push(6);
            minStack.Push(3);
            minStack.Push(9);
            minStack.Push(2);
            minStack.Pop();
            minStack.Pop();
            Console.WriteLine(minStack.StackMin());
            

            Console.WriteLine();
        }
    }
}
