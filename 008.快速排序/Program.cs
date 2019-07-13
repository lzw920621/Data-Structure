using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008.快速排序
{
    class Program
    {
        static void QuickSort(int[] dataArray,int left,int right)
        {
            if (left < right)
            {
                int x = dataArray[left];//基准数，把比它小或者等于它的放在它的左边，比它大的放右边
                int i = left;
                int j = right;//用来做循环的标志位
                while (i < j)//当i==j的时候，说明我们找到了一个中间位置，这个中间位置就是基准数应该所在的位置
                {
                    //从后往前比较（从右向左），找一个小于等于X的数,放在坑里，坑位于i的位置
                    while (i < j)
                    {
                        if (dataArray[j] < x)//找到一个小于基准数的数，把它放在基准数左边
                        {
                            dataArray[i] = dataArray[j];
                            break;
                        }
                        else
                        {
                            j--;//向左移动到下一个数作比较
                        }
                    }
                    //从前往后找一个比X大的数字放到坑里，坑现在的位于j的位置
                    while (i < j)
                    {
                        if (dataArray[i] > x)
                        {
                            dataArray[j] = dataArray[i];
                            break;
                        }
                        else
                        {
                            i++;
                        }
                    }
                }
                //跳出循环后，现在i=j了,i是中间位置
                dataArray[i] = x;//left--X--right
                //递归调用左右分区
                QuickSort(dataArray, left, i - 1);
                QuickSort(dataArray, i + 1, right);
            }
        }
        static void Main(string[] args)
        {
            int[] data = new int[] { 42, 20, 17, 27, 13, 8, 17, 35, 56, 23 };
            QuickSort(data,0,data.Length-1);
            foreach (var item in data)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}
