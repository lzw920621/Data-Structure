using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001.线性表
{
    class LinkList<T>:IListDS<T>
    {
        private Node<T> head;//存储一个头节点
        public LinkList()
        {
            head = null;
        }
        public int GetLength()
        {
            if (head == null)
            {
                return 0;
            }
            Node<T> temp = head;
            int count = 1;                                    
            while (temp.Next!=null)
            {
                count++;
                temp = temp.Next;
            }            
            return count;
        }
        public void Clear()
        {
            head = null;
        }
        public bool IsEmpty()
        {
            return head == null;
        }
        public void Add(T item)
        {
            Node<T> newNode = new Node<T>(item);//根据新的数据创建一个新的节点
            //如果头结点为空，那么这个新的节点就是头结点
            if (head == null)
            {
                head = newNode;
            }
            else
            {//把新来的节点放到链表的尾部
                Node<T> temp = head;
                while (true)
                {
                    if (temp.Next != null)
                    {
                        temp = temp.Next;
                    }
                    else 
                    {
                        break;
                    }
                }
                temp.Next = newNode;
            }
        }
        public void Insert(T item, int index)
        {
            Node<T> newNode = new Node<T>(item);
            if (index == 0)//插入到头结点
            {
                newNode.Next = head;
                head = newNode;
            }
            else 
            {
                Node<T> temp = head;
                for (int i = 1; i <= index-1; i++)
                {
                    temp = temp.Next;
                }
                Node<T> preNode = temp;
                Node<T> currentNode = temp.Next;
                preNode.Next = newNode;
                newNode.Next = currentNode;
            }
        }
        public T Delete(int index)
        {
            T data = default(T);
            if (index == 0)//删除头节点
            {
                data = head.Data;
                head = head.Next;
            }
            else
            {
                Node<T> temp = head;
                for (int i = 1; i <= index - 1; i++)
                {
                    temp = temp.Next;
                }
                Node<T> preNode = temp;
                Node<T> currentNode = temp.Next;
                data = currentNode.Data;
                preNode.Next = currentNode.Next;
            }
            return data;
        }
        public T this[int index]
        {
            get 
            {
                Node<T> temp = head;
                for (int i = 1; i <= index; i++)
                {
                    temp = temp.Next;//节点向后移一位
                }
                return temp.Data;
            }
        }
        public T GetEle(int index)
        {
            return this[index];
        }
        public int Locate(T value)
        {
            Node<T> temp = head;
            if (temp == null)
            {
                return -1;
            }
            else
            {
                int index = 0;
                while (true)
                {
                    if (temp.Data.Equals(value))
                    {
                        return index;
                    }
                    else
                    {
                        if (temp.Next != null)
                        {
                            index++;
                            temp = temp.Next;
                        }
                        else 
                        {
                            return -1;
                        }
                    }
                }
            }
        }
    }
}
