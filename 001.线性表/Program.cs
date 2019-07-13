using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001.线性表
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.使用BCL中的List线性表
            //List<string> strList = new List<string>();
            //strList.Add("123");
            //strList.Add("456");
            //strList.Add("789");
            //Console.WriteLine(strList[1]);
            //strList.Remove("789");
            //Console.WriteLine(strList.Count);
            //strList.Clear();
            //Console.WriteLine(strList.Count);
            //Console.ReadKey();

            //使用我们自己的顺序表
            //SeqList<string> seqlist = new SeqList<string>();
            LinkList<string> seqlist = new LinkList<string>();
            seqlist.Add("123");
            seqlist.Add("456");
            seqlist.Add("789");
            Console.WriteLine(seqlist.GetEle(0));
            Console.WriteLine(seqlist[0]);
            seqlist.Insert("777",1);
            for (int i = 0; i < seqlist.GetLength(); i++)
            {
                Console.Write(seqlist[i] + " ");
            }
            Console.WriteLine();
            seqlist.Delete(0);
            for (int i = 0; i < seqlist.GetLength(); i++)
            {
                Console.Write(seqlist[i] + " ");
            }
            Console.WriteLine();
            seqlist.Clear();
            Console.WriteLine(seqlist.GetLength());
            Console.ReadKey();
        }
    }
}
