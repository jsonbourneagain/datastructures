﻿using DataStructuresPart1.LinkedList;
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
            myLinkedList.AddLast(40);
            //myLinkedList.AddFirst(5);
            var k = 3;
            //myLinkedList.Reverse();
            Console.WriteLine($"{k} th node from the end is {myLinkedList.GetKthNodeFromTheEnd(k)}");
        }
    }
}
