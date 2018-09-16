using System;
using System.Linq;
using System.Collections.Generic;
public delegate int Smp(int x);
//Delegate is used to perform the lambda expression
namespace Transform
{
    public static class Transform 
    {
        //delegate is a pointer and object of delegate will point to the function
        public static int[] Map(this int[] a, Smp value )
        {
            for(int i=0;i<a.Length;i++)
            {
                //value is a object and it will call  a function that is present in the Map and perform the operation
                a[i]=value(a[i]);
            }
            return a;
        }
    }
}
