using System;
using System.Threading.Tasks;

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
            return Task.Run(()=> { return 500; });
        }
    }
}