using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresPart1
{
    public class MyArray
    {
        private int[] myArray;
        private int count;
        public MyArray(int length)
        {

            myArray = new int[length];
        }
        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }
        public void Insert(int item)
        {
            if (count == myArray.Length)
            {
                int[] newMyArray = new int[count * 2];
                for (int i = 0; i < count; i++)
                {
                    newMyArray[i] = myArray[i];
                }
                myArray = newMyArray;
            }
            myArray[count++] = item;
        }
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count)
                throw new ArgumentException($"{index} is not a valid argument");
            for (int i = index; i < count; i++)
            {
                myArray[i] = myArray[i + 1];
            }
            count--;
        }
        public int IndexOf(int item)
        {
            // O(n) runtime complexity of this program
            for (int i = 0; i < count; i++)
            {
                if (myArray[i] == item)
                    return i;
            }
            return -1;
        }
        public int Max()
        {
            if (count == 0)
                throw new Exception($"Array is emty.");
            int tempMax = myArray[0];
            for (int i = 1; i < count; i++)
            {
                if (myArray[i] > tempMax)
                    tempMax = myArray[i];
            }
            return tempMax;
        }
        public int[] Intersect(int[] arr)
        {
            int count = arr.Length < this.count ? arr.Length : this.count;
            List<int> lst = new List<int>();
            MyArray tempAr = new MyArray(count);

            for (int i = 0; i < count; i++)
            {
                if (IndexOf(arr[i]) >= 0)
                    lst.Add(arr[i]);
            }
            return lst.ToArray();
        }
        public void Reverse()
        {
            int[] newAr = new int[count];
            for (int i = count - 1; i >= 0; i--)
            {
                newAr[count - i - 1] = myArray[i];
            }
            myArray = newAr;
        }
        public void InsertAt(int item, int index)
        {
            int[] tempAr = new int[count + 1];
            for (int i = 0; i < index; i++)
            {
                tempAr[i] = myArray[i];
            }
            tempAr[index] = item;
            for (int j = index+1; j < count +1; j++)
            {

                tempAr[j] = myArray[j-1];
            }
            myArray = tempAr;
        }
    }
}
