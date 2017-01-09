using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF3._1_Millionaire
{
    static class ArrayExtension
    {
        public static T[] Shuffle<T>(this T[] a)
        {       
            Random rand = new Random();
            for (int i = a.Length - 1; i > 0; i--) 
            {
                int j = rand.Next(0, i + 1);
                T tmp = a[i];
                a[i] = a[j];
                a[j] = tmp;
            }

            return a;
        }
    }
}
