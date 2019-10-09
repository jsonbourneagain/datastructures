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

        //public MyHashTable()
        //{
        //    for (int i = 0; i < keyValues.Length; i++)
        //    {
        //        keyValues[i] = new LinkedList<KeyValue>();
        //    }
        //}
        public void Add(int key, string value)
        {
            var index = GetHash(key);

            if (keyValues[index] == null)
                keyValues[index] = new LinkedList<KeyValue>();


            var bucket = keyValues[index];

            foreach (var obj in bucket)
            {
                if (obj.Key == key)
                {
                    throw new Exception($"Key already exists.");
                }
            }

            // I'm using chaining here in case of Hash collision.
            bucket.AddLast(new KeyValue(key, value));

        }
        public string Get(int key)
        {
            return GetItem(key)?.Value;
        }

        public void Remove(int key)
        {
            var item = GetItem(key);
            var index = GetHash(key);

            // It's not working for reasons not known to me. keyValues[index] is a linked list and I want to remove an item from here. It should ideally work.
            if (item != null)
                keyValues[index].Remove(item);

            throw new Exception($"Key not found.");

        }

        // My Hash function. It'll return me the index, where to add or lookup.
        private int GetHash(int key)
        {
            var index = key % keyValues.Length;
            return index;
        }
        private KeyValue GetItem(int key)
        {
            var index = GetHash(key);
            KeyValue keyValue = null;

            var bucket = keyValues[index];

            foreach (var item in bucket)
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
