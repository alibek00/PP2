using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)

        {
            int n;
            
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];

            for (int i = 0; i < a.Length; ++i)
            {
                for (int j = 0; j < 2; ++j)
                {
                    Console.Write(a[i] + " ");
                    Console.ReadKey();
                }
            }
        }
    }
}
