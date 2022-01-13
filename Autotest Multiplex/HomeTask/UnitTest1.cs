using NUnit.Framework;
using System;
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
        static void pairwiseSum(int[] arr, int n)
        {
            int sum = 0;
            for (int i = 0; i + 1 < n; i++)
            {
                sum = arr[i] + arr[i + 1];
                Console.Write(sum + " ");
            }
        }
        public static void Main()
        {

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int n = arr.Length;
            pairwiseSum(arr, n);
        }
    }
}