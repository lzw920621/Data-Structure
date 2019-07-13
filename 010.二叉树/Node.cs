using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010.二叉树
{
    public class Node<T>
    {
        private T data; //数据域
        private Node<T> lChild; //左孩子
        private Node<T> rChild; //右孩子
        //构造器
        public Node(T val, Node<T> lp, Node<T> rp)
        {
            data = val;
            lChild = lp;
            lChild = rp;
        }
        //构造器
        public Node(Node<T> lp, Node<T> rp)
        {
            data = default(T);
            lChild = lp;
            rChild = rp;
        }
        //构造器
        public Node(T val)
        {
            data = val;
            lChild = null;
            rChild = null;
        }
        //构造器
        public Node()
        {
            data = default(T);
            lChild = null;
            rChild = null;
        }
        //数据属性
        public T Data
        {
            get
            {
                return data;
            }
            set
            {
                value = data;
            }
        }
        //左孩子属性
        public Node<T> LChild
        {
            get
            {
                return lChild;
            }
            set
            {
                lChild = value;
            }
        }
        //右孩子属性
        public Node<T> RChild
        {
            get
            {
                return rChild;
            }
            set
            {
                rChild = value;
            }
        }
    }
}
