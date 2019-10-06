using DataStructuresPart1.LinkedList;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructuresPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            var myLinkedList = new MyLinkedList();
            myLinkedList.AddLast(10);
            myLinkedList.AddLast(30);
            myLinkedList.AddLast(50);
            myLinkedList.AddLast(60);
            myLinkedList.AddLast(70);
            myLinkedList.AddLast(80);
            myLinkedList.PrintMiddle();

        }
    }
}
