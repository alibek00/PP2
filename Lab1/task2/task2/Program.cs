using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        class student
        {
              string name =Console.ReadLine();
              int course= Convert.ToInt32(Console.ReadLine());
              string ident= Console.ReadLine(string);
             public void getinfo (){

                Console.WriteLine("name is :{name}   course is : {course}   ident is :  {ident} ");
             }


        }


        static void Main(string[] args)
        {
            student tom;
            Console.ReadKey();
        }
    }
}
