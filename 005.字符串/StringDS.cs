using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005.字符串
{
    class StringDS
    {
        private char[] data;//字符数组用来存放字符串中的字符
        public StringDS(char[] array)
        {
            data = new char[array.Length];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = array[i];
            }
        }
        public StringDS(string str)
        {
            data = new char[str.Length];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = str[i];
            }
        }
        //根据索引返回字符串中的某个字符
        public char this[int index]
        {
            get { return data[index]; }
        }
        public int GetLength()
        {
            return data.Length;
        }
        //字符串比较，如果一样，返回0
        //如果不一样，当前比较字符小于s中对应字符,返回-1
        //如果当前字符大于s中对应字符，返回1
        public int Compare(StringDS s)
        {
            //取得两个字符串中长度更小的字符串长度
            int len = this.GetLength() < s.GetLength() ? this.GetLength() : s.GetLength();
            int index = -1;//存储第一个不相等字符的索引位置
            for (int i = 0; i < len; i++)
            {
                if (this[i] != s[i])
                {
                    index = i;
                    break;
                }
            }
            if (index != -1)
            {
                if (this[index] > s[index])
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (this.GetLength() == s.GetLength())
                {
                    return 0;
                }
                else if (this.GetLength() > s.GetLength())
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }
        public StringDS SubString(int index, int length)
        {
            char[] newData = new char[length];
            for (int i = 0 ; i < length; i++)
            {
                newData[i] = this[index + i];
            }
            return new StringDS(newData);
        }
        public static StringDS Concat(StringDS s1, StringDS s2)
        {
            char[] newData = new char[s1.GetLength() + s2.GetLength()];
            for (int i = 0; i < s1.GetLength(); i++)
            {
                newData[i] = s1[i];
            }
            for (int i = s1.GetLength(); i < newData.Length; i++)
            {
                newData[i] = s2[i - s1.GetLength()];
            }
            return new StringDS(newData);
        }
        public int IndexOf(StringDS s)
        {
            for (int i = 0; i <= this.GetLength()-s.GetLength(); i++)
            {
                bool IsEqual=true;
                for (int j = i; j < i+s.GetLength(); j++)
                {
                    if (this[j] != s[j-i])
                    {
                        IsEqual = false;
                        break;
                    }
                }
                if (IsEqual)
                {
                    return i;
                }
            }
            return -1;
            
        }
        
    }
}
