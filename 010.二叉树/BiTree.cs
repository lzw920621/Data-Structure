using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _003.队列;
namespace _010.二叉树
{
    //二叉树的二叉链表结构的实现
    public class BiTree<T>
    {
        //头结点
        private Node<T> head;
        //头节点属性
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
        //若p非空，删除p的左子树，返回删除的结点
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
        //若p非空，删除p的右子树，返回删除的结点
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
        //先序遍历（DLR）
        public void PreOrder(Node<T> root)
        {
            if(root==null)
            {
                return;
            }
            Console.WriteLine(root.Data);//处理根节点
            PreOrder(root.LChild);//遍历左子树
            PreOrder(root.RChild);//遍历右子树
        }
        //中序遍历（LDR）
        public void InOrder(Node<T> root)
        {
            if(root==null)
            {
                return;
            }
            PreOrder(root.LChild);//遍历左子树
            Console.WriteLine(root.Data);//处理根节点
            PreOrder(root.RChild);//遍历右子树
        }
        //后序遍历（LRD）
        public void PostOrder(Node<T> root)
        {
            if (root == null)
            {
                return;
            }
            PreOrder(root.RChild);//遍历右子树
            PreOrder(root.LChild);//遍历左子树
            Console.WriteLine(root.Data);//处理根节点            
        }
        //层序遍历（Level Order）
        public void LevelOrder(Node<T> root)
        {
            if(root==null)
            {
                return;
            }
            SeqQueue<Node<T>> sq = new SeqQueue<Node<T>>(50);
            sq.Enqueue(root);//根结点入队
            while(!sq.IsEmpty())
            {
                Node<T> temp = sq.Dequeue();//结点出队
                Console.WriteLine(temp.Data);//处理当前结点
                if(temp.LChild!=null)
                {
                    sq.Enqueue(temp.LChild);
                }
                if(temp.RChild!=null)
                {
                    sq.Enqueue(temp.RChild);
                }
            }
        }

        public int GetTreeHeight()//树的高度
        {
            return GetHeight(head);
        }
        private int GetHeight(Node<T> node)
        {
            if(node==null)
            {
                return 0;
            }
            else
            {
                int leftHeight = GetHeight(node.LChild);
                int rightHeight = GetHeight(node.RChild);
                return leftHeight > rightHeight ? leftHeight + 1 : rightHeight + 1;
            }
        }

    }
}
