using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002.栈
{
    class LinkStack<T>:IStackDS<T>
    {
        private Node<T> top;//栈顶元素节点
        private int count = 0;//栈中元素的个数
        public int Count//取得栈中元素的个数
        {
            get { return count; }
        }
        public int GetLength()//取得栈中元素的个数
        {
            return count;
        }
        public bool IsEmpty()//判断栈是否为空
        {
            return count == 0;
        }
        public void Clear()//清空
        {
            count = 0;
            top = null;
        }
        public void Push(T item)//入栈
        {
            Node<T> newNode = new Node<T>(item);
            newNode.Next = top;
            top = newNode;
            count++;
        }
        public T Pop()//出栈
        {
            T data = top.Data;
            top = top.Next;
            count--;
            return data;
        }
        public T Peek()//取得栈顶中的元素，不删除栈顶元素
        {
            return top.Data;
        }
    }
}
