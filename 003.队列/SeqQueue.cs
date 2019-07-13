using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003.队列
{
    public class SeqQueue<T>:IQueue<T>
    {
        private T[] data;
        private int count;//表示当前元素个数
        private int front;//队首元素索引减一
        private int rear;//队尾元素索引
        //构造器
        public SeqQueue(int size)
        {
            data = new T[size];
            count = 0;
            front = -1;
            rear = -1;
        }
        //构造器
        public SeqQueue()
            : this(10)
        { }
        public int Count
        {
            get { return count; }
        }
        public int GetLength()
        {
            return count;
        }
        public bool IsEmpty()
        {
            return count == 0;
        }
        public void Clear()
        {
            count = 0;
            front = rear = -1;            
        }
        public void Enqueue(T item)//入队
        {
            if (count == data.Length)
            {
                Console.WriteLine("队列已满，不可以再添加新的数据");
            }
            else
            {
                if (rear == data.Length - 1)
                {
                    data[0] = item;
                    rear = 0;
                }
                else
                {
                    rear++;
                    data[rear]=item;
                }
                count++;
            }
        }
        public T Dequeue()//出队
        {
            if (count > 0)
            {
                T temp = data[front + 1];
                front++;
                count--;
                return temp;
            }
            else
            {
                Console.WriteLine("队列为空，无法取得队首的数据");
                return default(T);
            }
        }
        public T Peek()
        {
            T temp = data[front + 1];
            return temp;
        }
    }
}
