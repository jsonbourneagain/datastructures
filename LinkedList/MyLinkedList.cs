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
                return;
            }
            else
            {
                var temp = First;
                First = First.Next;
                temp.Next = null;
            }
            Count--;
        }
        public void RemoveLast()
        {
            if (IsEmpty())
                throw new Exception($"Linked list is empty.");
            if (First == Last)
                First = Last = null;
            else
            {
                var previous = GetPreviousNode(Last);
                previous.Next = null;
                Last = previous;
            }
            Count--;
        }
        public int Size() => Count;

        // ToArray
        public int[] ToArray()
        {
            int[] arr = new int[Count];
            var current = First;
            int index = 0;

            while (current != null)
            {
                arr[index++] = current.Value;
                current = current.Next;
            }
            return arr;
        }
        public void Reverse()
        {
            if (IsEmpty())
                return;
            int[] arr = this.ToArray();
            First = Last = new Node(arr[Count - 1]);
            int c = Count - 2;
            First.Next = new Node(arr[Count - 1]);

            while (c >= 0)
            {
                AddLast(arr[c--]);
            }
            Count = arr.Length;
        }
        public int GetKthNodeFromTheEnd(int k)
        {
            if (IsEmpty() || Count < k || k <= 0)
                return -1;
            // Declare 2 pointers initially pointing to the first node. Move the second pointer untill it's k-1 nodes apart from the first
            var first = First; var second = First; int c = 0;
            while (c != k - 1)
            {
                second = second.Next;
                // If you don't know the size of the linked list, add a null check to catch Index out of range error => if(second == null) throw new Exception($"Invalid argument")
                c++;
            }
            // Then, move both pointers until second is null i.e reaches the last node. At this point, your first pointer points to target(kth node from end) node.
            while (second.Next != null) // Just an afterthought, you can also write it this way => while(second != Last)
            {
                first = first.Next;
                second = second.Next;
            }
            return first.Value;
        }
        // Exercise ( Print the middle of a Linked list assuming you don't know the size
        public void PrintMiddle()
        {
            if (IsEmpty())
                return;
            var first = First;
            var second = First;

            while (second != Last)
            {
                second = second.Next;
                if (second == Last)
                {
                    Console.WriteLine($"Middle: {first.Value}, {first.Next.Value}");
                    return;
                }
                second = second.Next;
                first = first.Next;
            }
            Console.WriteLine($"Middle : {first.Value}");
        }
        // Exercise ( Check if the linked list has a loop)
        public bool HasLoop()
        {
            var first = First; var second = First;
            do
            {
                first = first.Next;
                second = second.Next;
                second = second.Next;
            }
            while (first != second);
            return first == second;
        }
        private Node GetPreviousNode(Node node)
        {
            var current = First;
            while (current != null)
            {
                if (current.Next == node)
                    return current;
                current = current.Next;
            }
            return null;
        }

        // Methods added for Queue implementation using Linked List.
        public int RemoveFirstAndReturn()
        {
            int temp = default;
            if (IsEmpty())
                throw new Exception($"Linked list is empty.");
            if (First == Last)
            {
                First = Last = null;
                return First.Value;
            }
            else
            {
                var tempNode = First; temp = tempNode.Value;
                First = First.Next;
                tempNode.Next = null;
            }
            Count--;
            return temp;
        }
        public int Peek() => First.Value;
        // Contains
        // IndexOf
    }
}
