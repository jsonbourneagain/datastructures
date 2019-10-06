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
            TwoStackInAnArray two = new TwoStackInAnArray();
            //two.Push1(3);
            //two.Push2(5);
            //two.Push1(9);
            //two.Push2(99);
            //two.Push1(300);
            two.Push2(500);

            //var t1 = two.Pop1();
            //var t2 = two.Pop2();

            Console.WriteLine($"Stack 1 is empty {two.IsEmpty1()}");
            Console.WriteLine($"Stack 2 is empty {two.IsEmpty2()}");
            
            Console.WriteLine($"Stack 1 is full {two.IsFull1()}");
            Console.WriteLine($"Stack 2 is full {two.IsFull2()}");

            Console.WriteLine();
        }
    }
}
