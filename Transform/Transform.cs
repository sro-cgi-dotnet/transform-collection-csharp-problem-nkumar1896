using System;
using System.Linq;
using System.Collections.Generic;
public delegate int Smp(int x);
namespace Transform
{
    public static class Transform 
    {
        public static int[] Map(this int[] a, Smp value )
        {
            for(int i=0;i<a.Length;i++)
            {
                a[i]=value(a[i]);
            }
            return a;
        }
    }
}
