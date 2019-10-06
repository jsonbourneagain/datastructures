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
            
            Stacks.Stack myStack = new Stacks.Stack();
            myStack.Push(5);
            myStack.Push(4);
            myStack.Push(8);
            var tem = myStack.Pop();
            var tem1 = myStack.Pop();
            var tem2 = myStack.Pop();
            //var pek = myStack.Peek();
            Console.WriteLine(myStack.IsEmpty());
            
            Console.WriteLine();
        }
    }
}
