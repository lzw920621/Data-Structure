using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009二叉树
{
    public class BiTree<T>
    {
        private Node<T> head;
        //头引用属性
        public Node<T> Head
        {
            get
            {
                return head;
            }
            set
            {
                head = value;
            }
        }
        //构造器
        public BiTree()
        {
            head = null;
        }
        //构造器
        public BiTree(T val)
        {
            Node<T> p = new Node<T>(val);
            head = p;
        }
        //构造器
        public BiTree(T val, Node<T> lp, Node<T> rp)
        {
            Node<T> p = new Node<T>(val, lp, rp);
            head = p;
        }
        //判断是否是空二叉树
        public bool IsEmpty()
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //获取根结点
        public Node<T> Root()
        {
            return head;
        }
        //获取结点的左孩子结点
        public Node<T> GetLChild(Node<T> p)
        {
            return p.LChild;
        }
        //获取结点的右孩子结点
        public Node<T> GetRChild(Node<T> p)
        {
            return p.RChild;
        }
        //将结点p的左子树插入值为val的新结点，
        //原来的左子树成为新结点的左子树
        public void InsertL(T val, Node<T> p)
        {
            Node<T> tmp = new Node<T>(val);
            tmp.LChild = p.LChild;
            p.LChild = tmp;
        }
        //将结点p的右子树插入值为val的新结点，
        //原来的右子树成为新结点的右子树
        public void InsertR(T val, Node<T> p)
        {
            Node<T> tmp = new Node<T>(val);
            tmp.RChild = p.RChild;
            p.RChild = tmp;
        }
        //若p非空，删除p的左子树
        public Node<T> DeleteL(Node<T> p)
        {
            if ((p == null) || (p.LChild == null))
            {
                return null;
            }
            Node<T> tmp = p.LChild;
            p.LChild = null;
            return tmp;
        }
        //若p非空，删除p的右子树
        public Node<T> DeleteR(Node<T> p)
        {
            if ((p == null) || (p.RChild == null))
            {
                return null;
            }
            Node<T> tmp = p.RChild;
            p.RChild = null;
            return tmp;
        }
        //判断是否是叶子结点
        public bool IsLeaf(Node<T> p)
        {
            if ((p != null) && (p.LChild == null) && (p.RChild == null))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
