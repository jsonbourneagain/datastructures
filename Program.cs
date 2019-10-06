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
            // Reverse a string using stack
            string str = " 1 + 2  >";
            MyStack ms = new MyStack();
            Console.WriteLine(ms.IsBalancedExpression(str));
        }
    }
}
