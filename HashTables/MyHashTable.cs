using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresPart1.HashTables
{
    public class MyHashTable
    {
        // Create a HashTable from scratch.
        private class KeyValue
        {
            public int Key;
            public string Value;

            public KeyValue(int Key, string Value)
            {
                this.Key = Key;
                this.Value = Value;
            }
        }

        private LinkedList<KeyValue>[] keyValues = new LinkedList<KeyValue>[10];

        public MyHashTable()
        {
            for (int i = 0; i < keyValues.Length; i++)
            {
                keyValues[i] = new LinkedList<KeyValue>();
            }
        }
        public void Add(int key, string value)
        {
            var index = GetHash(key);

            foreach (var obj in keyValues[index])
            {
                if (obj.Key == key)
                {
                    throw new Exception($"Key already exists.");
                }
            }
            var item = new KeyValue(key, value);

            // I'm using chaining here in case of Hash collision.
            LinkedListNode<KeyValue> listNode = new LinkedListNode<KeyValue>(item);
            if(keyValues[index].Count == 0)
                keyValues[index].AddFirst(listNode);
            else
                keyValues[index].AddLast(listNode);

        }
        public string Get(int key)
        {
            return GetItem(key)?.Value;
        }
        // My Hash function. It'll return me the index to add or lookup.
        public void Remove(int key)
        {
            var item = GetItem(key);

            var index = GetHash(key);

            var node = keyValues[index].First.List;
            LinkedListNode<KeyValue> listNode = new LinkedListNode<KeyValue>(item);
            //keyValues[index].Contains(listNode);
            for (int i = 0; i < 5; i++)
            {
                
            }
        }
        private int GetHash(int key)
        {
            var index = key % keyValues.Length;
            return index;
        }
        private KeyValue GetItem(int key)
        {
            var index = GetHash(key);
            KeyValue keyValue = null;

            foreach (var item in keyValues[index])
            {
                if (item.Key == key)
                {
                    keyValue = new KeyValue(item.Key, item.Value);
                    break;
                }
            }
            return keyValue;
        }
    }
}
