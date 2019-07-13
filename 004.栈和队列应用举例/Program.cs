using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004.栈和队列应用举例
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            Queue<char> queue = new Queue<char>();
            for (int i = 0; i < str.Length; i++)
            {
                stack.Push(str[i]);
                queue.Enqueue(str[i]);
            }
            bool IsHui = true;
            while (stack.Count > 0)
            {
                if (stack.Pop() != queue.Dequeue())
                {
                    IsHui = false;
                    break;
                }
            }
            Console.WriteLine("是否是回文字符串：" + IsHui);
            Console.ReadKey();
        }
    }
}
