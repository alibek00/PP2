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
            int n = Convert.ToInt32(Console.ReadLine());
            string[] num2 = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(num2[i]);
                for( int j=1; j<=2;j++)
                {

                    Console.Write(m + " ");
                }
            }

            Console.ReadKey();   
            }
        
    }
}
