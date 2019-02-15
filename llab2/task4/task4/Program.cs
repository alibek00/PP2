using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fs = new FileStream(@"C:\text\first.txt", FileMode.Create)) { } //создал файл, если сущ то перезаписывается

            string fileName = "first.txt";  //сам файл который долж скопироаваться
            string first = @"C:\text\first.txt";      //источник
            string first1 = @"C:\text\first1.txt";    //цель

            string Ffile = Path.Combine(first, fileName);  // сведения о пути
            string Sfile = Path.Combine(first1, fileName);


            File.Copy(Ffile, Sfile, true);   //копирование
            File.Delete(@"C:\text\first.txt"); // удаление оригинала
            Console.ReadKey();
        }
    }
}
