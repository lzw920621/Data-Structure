using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002.栈
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用BCL中的Stack<T>
            //Stack<char> stack = new Stack<char>();
            //使用我们自己的栈
            //IStackDS<char> stack = new SeqStack<char>(30);
            //使用我们自己的链栈
            IStackDS<char> stack = new LinkStack<char>();
            stack.Push('a');
            stack.Push('b');
            stack.Push('c');
            Console.WriteLine("push a b c之后的数据个数为："+stack.Count);
            char temp= stack.Pop();//取得栈顶数据，并把栈顶的数据删除
            Console.WriteLine("pop之后得到的数据是：" + temp);
            Console.WriteLine("pop之后栈中的数据个数是：" + stack.Count);
            char temp2 = stack.Peek();//取得栈顶的数据，不删除
            Console.WriteLine("peek之后得到的数据是：" + temp2);
            Console.WriteLine("peek之后栈中的数据个数是：" + stack.Count);
            stack.Clear();
            Console.WriteLine("clear之后栈中的数据个数是：" + stack.Count);
            //Console.WriteLine("空栈的时候，取得栈顶的数据是：" + stack.Peek());
            //出现异常，当空栈时不要进行peek或pop操作
            Console.ReadKey();
        }
    }
}
