using System;

namespace DataStructuresPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray myArray = new MyArray(3);
            myArray.Insert(3);
            myArray.Insert(5);
            myArray.Insert(7);
            myArray.Insert(9);
            //int[] tempAr = new int[6] { 3, 7, 9, 10, 11, 12 };
            //myArray.RemoveAt(-1);
            //Console.WriteLine(myArray.IndexOf(700));
            //myArray.Reverse();
            //foreach (var item in myArray.Intersect(tempAr))
            //{
            //    Console.WriteLine(item);
            myArray.InsertAt(99, 2);
            //}
            myArray.Print();
            
            //Console.WriteLine(myArray.Max());

            //myArray.Print();
        }
    }
}
