using DataStructuresPart1.LinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresPart1.Queues
{
    public class QueueWithLinkedList : MyLinkedList
    {
        //private MyLinkedList MyLinkedList = new MyLinkedList();

        public void Enqueue(int item)
        {
            base.AddLast(item);
        }
        public int Dequeue()
        {
            return base.RemoveFirstAndReturn();
        }
        public int Peek() => base.Peek();

    }
}
