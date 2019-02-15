using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Person
    {
        public string name;
        public int age;
        public string  id;
        public int year;

        public Person() { name = "Alibek"; age = 21; id = "12bd239485"; year = 2; }     

        public Person(string n) { name = "Nurbek"; age = 20;  id = "13bd239485";year = 3; }

        public Person(string n , int d) { name = "Aisultan"; age = 19; id="10bd394859"; year = 4; }   

        public void GetInfo()
        {
            Console.WriteLine($"Имя: {name}  Возраст: {age} Айди: {id} Курс: {year} ");
        }
    }
    class Program
    {
        


        static void Main(string[] args)
        {
            Person tom = new Person();          
            Person bob = new Person("Bob");     
            Person sam = new Person("Sam", 25);

            bob.GetInfo();
            tom.GetInfo();
            sam.GetInfo();


            Console.ReadKey();

        }
    }
}
