using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringtoshow1, stringtoshow2;

            string name = "mdsfkms;g";
            string fame = "ljdsn";

            int age = 5;
            int course = 2;

            stringtoshow1 = name + " " + fame + " " + age + " " + course;
            Console.WriteLine(stringtoshow1);

            name = "sgs";
            fame = "jjjj";

            age = 0;
            course = 4;
            stringtoshow2 = name + "  " + fame + "  " + age + "  " + course;

            Console.WriteLine(stringtoshow2);
        }
    }
}
