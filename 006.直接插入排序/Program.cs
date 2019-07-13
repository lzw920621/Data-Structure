using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006.直接插入排序
{
    class Program
    {
        static void InsertSort(int[] dataArray)
        {
            for (int i = 1; i < dataArray.Length; i++)
            {
                //拿到索引i未知的元素和前面所有的元素作比较
                //如果发现比它大的就让比他大的向后移动
                int iValue=dataArray[i];
                bool isInsert = false;
                for (int j = i-1; j >=0; j--)
                {
                    if (dataArray[j] > iValue)
                    {
                        dataArray[j + 1] = dataArray[j];
                        //dataArray[j] = iValue;
                    }
                    else
                    {
                        //发现比ivalue小的值就不移动了
                        dataArray[j+1] = iValue;
                        isInsert = true;
                        break;
                    }
                }
                if (isInsert == false)
                {
                    dataArray[0] = iValue;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] data = new int[] { 42,20,17,27,13,8,17,48};
            InsertSort(data);
            foreach (var item in data)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}
