using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001.线性表
{
    interface IListDS<T>
    {
        int GetLength();//获取长度
        void Clear();
        bool IsEmpty();
        void Add(T item);
        void Insert(T item,int Index);
        T Delete(int Index);
        T this[int Index] { get; }
        T GetEle(int Index);
        int Locate(T value);
    }
}
