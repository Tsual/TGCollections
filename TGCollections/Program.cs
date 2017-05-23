using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace TGCollections
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Hello World!");
        }
    }

    class Tt
    {



        public static Task<int> func1()
        {
            System.Threading.Thread.Sleep(100);
            return Task.Run(() => { return 500; });
        }

        public static void func2()
        {
            int[] ar = { 0, 1 };
            List<int> arr = new List<int> { 0, 1, 1 };
            var e = arr.GetEnumerator();
            
            
        }

    }
}