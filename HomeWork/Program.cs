using System;
using System.Collections.Generic;
using System.Reflection;

namespace HomeWork
{
    internal class Program
    {
        class SwapList<T> : List<T>
        {
             public void SwapIndexes(int i,int ii,T z)
            {             
                z = this[i];
                this[i] = this[ii];
                this[ii]=z;
            }

        }
        static void Main(string[] args)
        {
            int obj = 3, i = 0, ii = 2;
            double obj2 = 6.4;
            string b= "";
            static void PrintTheObj<T>(T obj)
            {
                Console.WriteLine(obj);
            }

            PrintTheObj(obj);
           

            PrintTheObj(obj2);



            SwapList<string> s = new SwapList<string>() { "Dudi", "Chaim", "Shimi" };
            s.SwapIndexes(i, ii, b);
            for(int j = 0; j < s.Count; j++)
            {
                PrintTheObj(s[j]);
            }
           
            
            Console.Read();
        } 

    }
}
