using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresPart1.LinkedList
{
    public class MyLinkedList
    {
        private class Node
        {
            private int Value;
            public Node Next;
            public Node(int value) => this.Value = value;
        }
        private Node First;
        private Node Last;

        // AddLast
        public void AddLast(int item)
        {
            var node = new Node(item);

            if (First == null)
                First = Last = node;
            else
            {
                // this last is prior to adding new node to the Linked List.
                Last.Next = node;
                // this last after adding the node to the list. the recently added node now becomes the last node.
                Last = node;
            }
        }

        // AddFirst
        public void AddFirst(int item)
        {
            var node = new Node(item);

            if (First == null)
                First = Last = node;
            else
            {
                First.Next = node;
                First = node;
            }
        }

        // DeleteFirst
        // DeleteLast
        // Contains
        // IndexOf
    }
}
