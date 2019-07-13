using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005.字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            StringDS str = new StringDS("abcdefg");
            StringDS str1 = new StringDS("hijklmn");
            StringDS str2 = new StringDS("abcdefg");
            string s = "abc";
            string s1 = "abc";
            Console.WriteLine(s == s1);
            //对于值类型，如果对象的值相等，则相等运算符 (==) 返回 true，否则返回 false。
            //对于string 以外的引用类型，==比较的是两个对象的地址，如果两个对象引用同一个对象，则 == 返回 true。
            //对于 string 类型，== 比较字符串的值。
            Console.WriteLine(str == str2);//==比较的是两个实例化对象的引用地址（指针），所以结果是false
            Console.WriteLine(str.Equals(str2));//同上
            Console.WriteLine("字符串str中索引为2的字符是"+str[2]);
            Console.WriteLine("字符串str1的长度是" + str1.GetLength());
            Console.WriteLine(str.Compare(str1));
            //Console.WriteLine(str.SubString(2, 2)==new StringDS("cd"));
            
            Console.WriteLine(s == s1);
            Console.WriteLine(str1.IndexOf(new StringDS("jk")));
            Console.ReadKey();
        }
    }
}
