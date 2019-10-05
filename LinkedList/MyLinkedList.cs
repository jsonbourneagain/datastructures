using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresPart1.LinkedList
{
    public class MyLinkedList
    {
        private class Node
        {
            public int Value;
            public Node Next;
            public Node(int value) => this.Value = value;
        }
        private Node First;
        private Node Last;
        private int Count;

        // AddLast
        public void AddLast(int item)
        {
            var node = new Node(item);

            if (IsEmpty())
                First = Last = node;
            else
            {
                // this last is prior to adding new node to the Linked List.
                Last.Next = node;
                // this last after adding the node to the list. the recently added node now becomes the last node.
                Last = node;
            }
            Count++;
        }

        // AddFirst
        public void AddFirst(int item)
        {
            var node = new Node(item);

            if (IsEmpty())
                First = Last = node;
            else
            {
                node.Next = First;
                First = node;
            }
            Count++;
        }

        // IndexOf
        public int IndexOf(int item)
        {
            int index = 0;
            var current = First;
            while (current != null)
            {
                if (current.Value == item)
                    return index;
                current = current.Next;
                index++;
            }
            return -1;
        }
        private bool IsEmpty() => (First == null);

        // Contains
        public bool Contains(int item) => IndexOf(item) != -1;

        // DeleteFirst
        public void RemoveFirst()
        {
            if (IsEmpty())
                throw new Exception($"Linked list is empty.");
            if (First == Last)
            {
                First = Last = null;
                Count--;
                return;
            }
            var temp = First;
            First = First.Next;
            temp.Next = null;
            Count--;
        }
        public void RemoveLast()
        {
            if (IsEmpty())
                throw new Exception($"Linked list is empty.");
            if (First == Last)
            {
                First = Last = null;
                Count--;
                return;
            }
            var previous = GetPreviousNode(Last);
            previous.Next = null;
            Last = previous;
            Count--;
        }
        public int Size()
        {
            // Problem with this approach is that every time you call the Size(), you're looping over the list. It's very inefficient.
            //if (IsEmpty())
            //    return 0;
            //if (First == Last)
            //    return 1;
            //var current = First;
            //int count = 0;
            //while (current != null)
            //{
            //    current = current.Next;
            //    count++;
            //}
            return Count;
        }
        private Node GetPreviousNode(Node node)
        {
            var current = First;
            while (current != null)
            {
                if (current.Next == Last)
                    return current;
                current = current.Next;
            }
            return null;
        }
        // Contains
        // IndexOf
    }
}
