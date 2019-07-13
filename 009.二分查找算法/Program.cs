using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009.二分查找算法
{
    class Program
    {
        //1.用递归实现二分查找算法
        static int BinarySearch(int n, int[] array, int leftIndex, int rightIndex)
        {
            if (leftIndex > rightIndex)
            {
                return -1;
            }
            else
            {
                int midIndex = leftIndex + (rightIndex - leftIndex) / 2;
                if (n == array[midIndex])
                {
                    return midIndex;
                }
                else if (n < array[midIndex])
                {
                    return BinarySearch(n, array, leftIndex, midIndex - 1);
                }                
                else
                {
                    return BinarySearch(n, array, midIndex + 1, rightIndex);
                }            
            }            
        }
        //2.用循环来实现二分查找算法
        static int BinarySearch2(int n, int[] array, int leftIndex, int rightIndex)
        {
            while (leftIndex < rightIndex)
            {
                int midIndex = leftIndex + (rightIndex - leftIndex) / 2;
                if (n == array[midIndex])
                {
                    return midIndex;
                }
                else if (n < array[midIndex])
                {
                    rightIndex = midIndex - 1;
                }
                else
                {
                    leftIndex = midIndex + 1;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 1, 2, 3, 4, 6, 8, 10, 15, 32, 41, 56, 67, 89, 101 };
            int targetIndex = BinarySearch2(56, myArray, 0, myArray.Length - 1);
            Console.WriteLine(targetIndex);
            Console.ReadKey();
        }
    }
}
