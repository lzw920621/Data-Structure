using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001.线性表
{
    //单链表的结点
    class Node<T>
    {
        private T data;//存储数据
        public T Data
        {
            get { return data; }
            set { data = value; }
        }
        private Node<T> next;//指针，指向下一个元素
        public Node<T> Next
        {
            get { return next; }
            set { next = value; }
        }
        public Node()//构造函数
        {
            data = default(T);
            next = null;
        }
        public Node(T value)
        {
            data = value;
            next = null;
        }
        public Node(T value, Node<T> next)
        {
            this.data = value;
            this.next = next;
        }
        public Node(Node<T> next)
        {
            this.next = next;
        }
    }
}
