using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeTask
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public static void Main()
        {
            var arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var newArr = GetNewArray(arr);

            Console.WriteLine("Old Array: ");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nNew Array: ");
            foreach (var item in newArr)
            {
                Console.Write(item + " ");
            }
        }
        public static List<int> GetNewArray(int[] oldArray)
        {
            var list = new List<int>();

            for (var i = 0; i < oldArray.Length; i++)
            {
                if (i + 1 < oldArray.Length)
                {
                    list.Add(oldArray[i] + oldArray[++i]);
                }
                else
                    list.Add(oldArray[i]);
            }
            return list;
        }
    }
}