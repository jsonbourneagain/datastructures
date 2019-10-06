using DataStructuresPart1.LinkedList;
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
            string str = "abcdef";

            Stack<char> charStack = new Stack<char>();
            foreach (char c in str)
            {
                charStack.Push(c);
            }
            StringBuilder revStr = new StringBuilder();
            foreach (char c in charStack)
            {
                revStr.Append(c);
            }
            Console.WriteLine(revStr.ToString());
        }
    }
}
