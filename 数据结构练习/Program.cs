using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构练习
{
    class Program
    {       
        static void Main(string[] args)
        {
            int[] La = new int[] {1, 3, 6, 7, 9, 12, 17};
            int[] Lb = new int[] { 2, 4, 5, 8, 10, 11, 13, 14, 15 };
            int[] Lc = Connect(La, Lb);
            for (int i = 0; i < Lc.Length; i++)
            {
                Console.Write(Lc[i]+" ");
            }
            Console.ReadKey();
        }
        public static int[] Connect(int[] La, int[] Lb)
        {
            int x = 0, y = 0;
            int[] Lc = new int[La.Length + Lb.Length];
            for (int i = 0; i < Lc.Length; i++)
            {
                if (x < La.Length && y < Lb.Length)
                {
                    if (La[x] <= Lb[y])
                    {
                        Lc[i] = La[x];
                        if ( x < La.Length )
                        {
                            x++;
                        }
                    }
                    else
                    {
                        Lc[i] = Lb[y];
                        if ( y < Lb.Length )
                        {
                            y++;
                        }
                    }
                }
                else if (x < La.Length)
                {
                    Lc[i] = La[x];
                    x++;
                }
                else
                {
                    Lc[i] = Lb[y];
                    y++;
                }
            }
            return Lc;
        }
    }
}
